public class NRZEncoder {
    // Метод для кодирования сообщения в NRZ
    public static String encodeNRZ(String message) {
        StringBuilder encodedMessage = new StringBuilder();

        // Перебираем каждый символ в сообщении
        for (char c : message.toCharArray()) {
            // Переводим символ в двоичное представление
            String binary = Integer.toBinaryString(c);

            // Перебираем каждый бит в двоичном представлении
            for (int i = 0; i < binary.length(); i++) {
                // Если бит равен '0', добавляем '0' к закодированному сообщению
                if (binary.charAt(i) == '0') {
                    encodedMessage.append("0");
                } else {
                    // Если бит равен '1', добавляем '1' к закодированному сообщению
                    encodedMessage.append("1");
                }
            }
        }

        // Возвращаем закодированное сообщение
        return encodedMessage.toString();
    }

    public static void main(String[] args) {
        String message = "Rest in peace"; // Исходное сообщение
        String encodedMessage = encodeNRZ(message); // Кодируем сообщение в NRZ
        System.out.println("Encoded Message: " + encodedMessage); // Выводим закодированное сообщение
    }
}

