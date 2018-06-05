<?php 	
include_once("bd.php");
?>

<!DOCTYPE html>
</html lang="en">
<html>
<head>
    <meta charset="UTF-8">
    <title>Create your account</title>
    <link rel="stylesheet" href="registration.css">
</head>
<body>
    <h2>Create your account</h2>
    <form action="form.php" method="post">
        <p>
            <label>Login:<br></label>
            <input class="submit1" name="login" type="text" size="20" maxlength="20">
        </p>
        <p>
            <label>Password:<br></label>
            <input class="submit1" name="pass" type="password" size="20" maxlength="20">
        </p>
        <p>
            <input class="submit" type="submit" name="submit" value="SIGN UP">
        </p>
    </form>
</body>
</html>
