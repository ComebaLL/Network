import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class TCPServer {
    public static void main(String[] args) {
        try {
            // Создаем серверный сокет, прослушивающий порт 9876
            ServerSocket serverSocket = new ServerSocket(9876);

            System.out.println("Сервер запущен. Ожидание подключений...");

            // Ждем подключения клиента
            Socket clientSocket = serverSocket.accept();
            System.out.println("Клиент подключен.");

            // Получаем потоки для чтения и записи данных
            BufferedReader in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
            PrintWriter out = new PrintWriter(clientSocket.getOutputStream(), true);

            // Ждем, пока клиент отправит сообщение
            String message = in.readLine();
            System.out.println("Получено сообщение от клиента: " + message);

            // Отправляем ответ клиенту
            out.println("Привет, клиент!");

            // Закрываем соединение
            clientSocket.close();
            serverSocket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}


