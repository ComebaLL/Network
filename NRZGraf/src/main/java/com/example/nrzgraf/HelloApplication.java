package com.example.nrzgraf;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.chart.LineChart;
import javafx.scene.chart.NumberAxis;
import javafx.scene.chart.XYChart;
import javafx.stage.Stage;

public class HelloApplication extends Application {

    public static String encodeNRZ(String message) {
        StringBuilder encodedMessage = new StringBuilder();

        for (char c : message.toCharArray()) {
            String binary = String.format("%8s", Integer.toBinaryString(c)).replace(' ', '0');

            for (int i = 0; i < binary.length(); i++) {
                encodedMessage.append((binary.charAt(i) == '0') ? "0" : "1");
            }
        }

        return encodedMessage.toString();
    }

    @Override
    public void start(Stage stage) {
        String message = "закодированный дед"; // Исходное сообщение
        String encodedMessage = encodeNRZ(message); // Кодируем сообщение в NRZ

        // Строим график для закодированного сообщения NRZ
        LineChart<Number, Number> lineChart = createLineChart(encodedMessage);

        // Отображаем график в окне
        Scene scene = new Scene(lineChart, 800, 600);
        stage.setTitle("NRZ Encoding Chart");
        stage.setScene(scene);
        stage.show();
    }

    private LineChart<Number, Number> createLineChart(String encodedMessage) {
        final NumberAxis xAxis = new NumberAxis();
        final NumberAxis yAxis = new NumberAxis();

        final LineChart<Number, Number> lineChart = new LineChart<>(xAxis, yAxis);
        lineChart.setTitle("NRZ Encoding Chart");

        XYChart.Series<Number, Number> series = new XYChart.Series<>();
        series.setName("Encoded Message");

        for (int i = 0; i < encodedMessage.length(); i++) {
            char bit = encodedMessage.charAt(i);
            int value = (bit == '0') ? 0 : 1;
            series.getData().add(new XYChart.Data<>(i, value));
            series.getData().add(new XYChart.Data<>(i + 1, value));
        }

        lineChart.getData().add(series);

        return lineChart;
    }

    public static void main(String[] args) {
        launch(args);
    }
}
