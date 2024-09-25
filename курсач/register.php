<?php
session_start();

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
  // Здесь должна быть логика регистрации пользователя.
  // В данном примере новые учетные данные просто добавляются к предопределенным учетным данным.
  $newUsername = $_POST['newUsername'];
  $newPassword = $_POST['newPassword'];

  // Пример предопределенных учетных данных (пароль можно хранить в хешированном виде в реальном приложении).
  $users = [
    'user1' => 'password1',
    'user2' => 'password2',
  ];

  // Проверка, что такого пользователя еще нет.
  if (!isset($users[$newUsername])) {
    $users[$newUsername] = $newPassword;
    echo 'success';
  } else {
    echo 'error';
  }
} else {
  header('Location: index.html');
}
?>

