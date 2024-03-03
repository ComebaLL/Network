import java.net.DatagramPacket;
import java.net.DatagramSocket;

public class UDPServer {
    public static void main(String[] args) {
        try {
            // Создание DatagramSocket для прослушивания порта 9876
            DatagramSocket socket = new DatagramSocket(9876);

            // Буфер для хранения принятых данных
            byte[] receiveBuffer = new byte[1024];

            // DatagramPacket для получения данных
            DatagramPacket receivePacket = new DatagramPacket(receiveBuffer, receiveBuffer.length);

            System.out.println("Сервер запущен. Ожидание сообщений...");

            while (true) {
                // Получение данных от клиента
                socket.receive(receivePacket);

                // Преобразование байтов в строку
                String message = new String(receivePacket.getData(), 0, receivePacket.getLength());

                // Вывод полученного сообщения
                System.out.println("Получено сообщение: " + message);

                // Очистка буфера для следующего приема
                receivePacket.setLength(receiveBuffer.length);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

