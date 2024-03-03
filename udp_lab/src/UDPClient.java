import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;

public class UDPClient {
    public static void main(String[] args) {
        try {
            // Создаем сокет для отправки UDP-пакетов
            DatagramSocket socket = new DatagramSocket();

            // Строка сообщения, которую мы отправляем
            String message = "Привет, сервер!";

            // IP-адрес сервера (localhost в данном примере)
            InetAddress serverAddress = InetAddress.getByName("localhost");

            // Порт сервера, на который мы отправляем сообщение (9876 в данном примере)
            int serverPort = 9876;

            // Преобразуем сообщение в байты
            byte[] sendData = message.getBytes();

            // Создаем пакет для отправки данных на сервер
            DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, serverAddress, serverPort);

            // Отправляем пакет на сервер
            socket.send(sendPacket);

            System.out.println("Сообщение отправлено: " + message);

            // Опционально: закрыть сокет после отправки сообщения
            // socket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}


