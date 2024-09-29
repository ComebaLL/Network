from flask import Flask, render_template, request 
from flask_socketio import SocketIO, emit
from flask_cors import CORS
import json
import signal
import sys
import os

app = Flask(__name__)
socketio = SocketIO(app)
CORS(app)  # Это разрешит все источники делать запросы к вашему серверу

# Хранилище для истории сообщений
chat_history = []

# Файл для хранения истории чата
CHAT_HISTORY_FILE = 'chat_history.txt'

def load_chat_history():
    """Загружает историю чата из файла."""
    if os.path.exists(CHAT_HISTORY_FILE):
        with open(CHAT_HISTORY_FILE, 'r', encoding='utf-8') as file:
            for line in file:
                if line.strip():  # Пропустить пустые строки
                    chat_history.append(json.loads(line.strip()))

def save_message_to_file(message):
    """Сохраняет сообщение в файл."""
    with open(CHAT_HISTORY_FILE, 'a', encoding='utf-8') as file:
        file.write(json.dumps(message) + '\n')

@app.route('/')
def index():
    return render_template('chat.html')

@socketio.on('send_message')
def handle_message(data):
    username = data['username']
    message = data['message']
    
    # Создаем сообщение
    chat_message = {'username': username, 'message': message}

    # Сохраняем сообщение в истории и в файл
    chat_history.append(chat_message)
    save_message_to_file(chat_message)

    # Отправляем сообщение всем подключенным клиентам
    emit('receive_message', chat_message, broadcast=True)

@socketio.on('get_history')
def get_history():
    # Отправляем историю чата новому пользователю
    emit('chat_history', chat_history)

@socketio.on('connect')
def handle_connect():
    # Получаем IP-адрес и порт клиента
    client_ip = request.remote_addr
    client_port = request.environ.get('REMOTE_PORT')
    print(f'User connected from {client_ip}:{client_port}')  # Отправка информации на серверную консоль
    
    # Отправляем историю чата при подключении
    emit('chat_history', chat_history)

    # Также уведомляем всех клиентов о новом подключении
    emit('user_connected', {'ip': client_ip, 'port': client_port}, broadcast=True)

def signal_handler(sig, frame):
    print('Shutting down gracefully...')
    socketio.stop()
    sys.exit(0)

if __name__ == '__main__':
    signal.signal(signal.SIGINT, signal_handler)
    load_chat_history()  # Загружаем историю чата при запуске
    socketio.run(app, host='0.0.0.0', port=12345)









