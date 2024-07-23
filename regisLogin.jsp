<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Login</title>
</head>
<body>
    <h2>Student Login</h2>
    <form action="validateLogin" method="POST">
        <label for="ssn">Enter your SSN:</label>
        <input type="text" id="ssn" name="ssn">
        <input type="submit" value="Login">
    </form>
</body>
</html>