module com.example.nrzgraf {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.nrzgraf to javafx.fxml;
    exports com.example.nrzgraf;
}