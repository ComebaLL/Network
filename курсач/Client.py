import socket
import json
import threading

# Функция для приема сообщений от сервера
def receive_messages(client_socket):
    while True:
        try:
            message = client_socket.recv(1024).decode('utf-8')
            if message:
                print(message)
            else:
                # Если сервер закрыл соединение
                print("Connection closed by server")
                client_socket.close()
                break
        except:
            print("An error occurred.")
            client_socket.close()
            break

# Основная функция клиента
def start_client():
    server_host = '127.0.0.1'  # IP-адрес сервера (локальный адрес)
    server_port = 12345       # Порт, на котором работает сервер

    client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    client_socket.connect((server_host, server_port))

    # Получение IP и порта пользователя
    client_ip, client_port = client_socket.getsockname()
    print(f"Connected to server from {client_ip}:{client_port}")

    # Запуск потока для приема сообщений от сервера
    receive_thread = threading.Thread(target=receive_messages, args=(client_socket,))
    receive_thread.start()

    # Ввод имени пользователя
    username = input("Enter your username: ")

    # Основной цикл отправки сообщений
    while True:
        message = input("You: ")
        if message.lower() == 'exit':
            client_socket.sendall(json.dumps({"username": username, "message": "has left the chat"}).encode('utf-8'))
            break

        # Подготовка сообщения в формате JSON
        json_message = json.dumps({"username": username, "message": message})
        client_socket.sendall(json_message.encode('utf-8'))

    client_socket.close()

if __name__ == "__main__":
    start_client()
