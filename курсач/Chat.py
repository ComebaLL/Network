import asyncio
from pywebio import start_server
from pywebio.input import *
from pywebio.output import *
from pywebio.session import defer_call, info as session_info, run_async, run_js

chat_msgs = []
online_users = set()

MAX_MESSAGES_COUNT = 100
CHAT_HISTORY_FILE = 'chat_history.txt'

# Функция для сохранения истории чата в файл
def save_chat_history():
    with open(CHAT_HISTORY_FILE, 'a', encoding='utf-8') as f:  # Добавили encoding='utf-8'
        for msg in chat_msgs:
            f.write(f'{msg[0]}: {msg[1]}\n')


# Функция для загрузки истории чата
def load_chat_history():
    try:
        with open(CHAT_HISTORY_FILE, 'r', encoding='utf-8') as f:  # Чтение с кодировкой UTF-8
            return [tuple(line.strip().split(': ', 1)) for line in f.readlines()]
    except FileNotFoundError:
        return []

# основная функция
async def main():   
    global chat_msgs
    chat_msgs = load_chat_history()  # Загружаем историю при старте

    put_markdown("## 🧊 Добро пожаловать в онлайн чат.")

    msg_box = output()
    put_scrollable(msg_box, height=300, keep_bottom=True)

    nickname = await input("Войти в чат", required=True, placeholder="Ваше имя", validate=lambda n: "Такой ник уже используется!" if n in online_users or n == '📢' else None)
    online_users.add(nickname)

    # Лог подключения в консоль браузера с ником пользователя
    run_js(f'console.log("Пользователь {nickname} подключился")')

    # Отображение всей истории чата новому пользователю
    for msg in chat_msgs:
        msg_box.append(put_markdown(f"`{msg[0]}`: {msg[1]}"))

    # Сообщение всем участникам чата о подключении нового пользователя
    chat_msgs.append(('📢', f'`{nickname}` присоединился к чату!'))
    msg_box.append(put_markdown(f'📢 `{nickname}` присоединился к чату'))
    
    save_chat_history()  # Сохраняем историю после присоединения

    # Отображаем историю сообщений и добавляем обновления для каждого сообщения
    refresh_task = run_async(refresh_msg(nickname, msg_box))

    while True:
        data = await input_group("💭 Новое сообщение", [
            input(placeholder="Текст сообщения ...", name="msg"),
            actions(name="cmd", buttons=["Отправить", {'label': "Выйти из чата", 'type': 'cancel'}])
        ], validate=lambda m: ('msg', "Введите текст сообщения!") if m["cmd"] == "Отправить" and not m['msg'] else None)

        if data is None:
            break

        # Отправляем сообщение в чат
        msg_box.append(put_markdown(f"`{nickname}`: {data['msg']}"))
        chat_msgs.append((nickname, data['msg']))
        save_chat_history()  # Сохраняем историю после каждого сообщения

    refresh_task.close()

    online_users.remove(nickname)
    toast("Вы вышли из чата!")
    
    # Сообщение всем о выходе пользователя
    msg_box.append(put_markdown(f'📢 Пользователь `{nickname}` покинул чат!'))
    chat_msgs.append(('📢', f'Пользователь `{nickname}` покинул чат!'))
    save_chat_history()  # Сохраняем историю при выходе

    put_buttons(['Перезайти'], onclick=lambda btn: run_js('window.location.reload()'))


# Функция для обновления сообщений
async def refresh_msg(nickname, msg_box):
    global chat_msgs
    last_idx = len(chat_msgs)

    while True:
        await asyncio.sleep(1)
        
        for m in chat_msgs[last_idx:]:
            if m[0] != nickname: # если сообщение не от текущего пользователя
                msg_box.append(put_markdown(f"`{m[0]}`: {m[1]}"))
        
        # удаляем старые сообщения
        if len(chat_msgs) > MAX_MESSAGES_COUNT:
            chat_msgs = chat_msgs[len(chat_msgs) // 2:]
        
        last_idx = len(chat_msgs)

if __name__ == "__main__":
    start_server(main, debug=True, port=8080, cdn=False)
