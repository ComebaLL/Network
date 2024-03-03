import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class TCPClient {
    public static void main(String[] args) {
        try {
            // Подключаемся к серверу по адресу localhost и порту 9876
            Socket socket = new Socket("localhost", 9876);

            // Получаем потоки для чтения и записи данных
            BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter out = new PrintWriter(socket.getOutputStream(), true);

            // Отправляем сообщение серверу
            String message = "Привет, сервер!";
            out.println(message);
            System.out.println("Сообщение отправлено: " + message);

            // Ждем ответа от сервера
            String response = in.readLine();
            System.out.println("Ответ от сервера: " + response);

            // Закрываем соединение
            socket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}



