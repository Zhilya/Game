<?php 	
include_once("bd.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Web-compiler</title>
	<link rel="stylesheet" href="index.css">
</head>
<body>
	<h2>Web-compiler</h2>
	<form action="login.php" method="post">
		<label>Login: </label><br>
		<input type="text" name="login" size="20" required/><br><br>
		<label class="pass" >Password: </label><br>
		<input type="password" name="pass" size="20" required><br> 
		<td colspan="2"><input style="margin-top: 15px;" class="submit" type="submit" name="submit" value="Log in">
		</form>
		<br>

		<label class="time" >For the first time on Web-compiler?</label>
		<form action="registration.php" method="post">
		<input class="submit" type="submit" name="submit" value="Sign in">
		</form>

		<form action="compiler.php" method="post">
		<input class="submit1" type="submit" value="without registration!">
		</form>
	</form>
</body>
</html>



