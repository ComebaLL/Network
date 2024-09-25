<?php
session_start();

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
  // Здесь должна быть проверка учетных данных и другие необходимые действия для входа.
  // В данном примере проверка просто проводится на основе предопределенных учетных данных.
  $username = $_POST['username'];
  $password = $_POST['password'];

  // Пример предопределенных учетных данных (пароль можно хранить в хешированном виде в реальном приложении).
  $validUser = 'user1';
  $validPassword = 'password1';

  if ($username === $validUser && $password === $validPassword) {
    $_SESSION['username'] = $username;
    echo 'success';
  } else {
    echo 'error';
  }
} else {
  header('Location: index.html');
}
?>
