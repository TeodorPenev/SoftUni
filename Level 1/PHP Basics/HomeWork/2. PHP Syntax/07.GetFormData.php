</<!doctype html>
<head>
    <meta charset="UTF-8">
    <title>Get Form Data</title>
</head>
<body>
<form action="" method="post">
<input type="text" name="name" placeholder="Name...">
<input type="text" name="age" placeholder="Age...">
<input type="radio" name="butS" value="male"> Male
<input type="radio" name="butS" value="female"> Female
    <input type="submit">
</form>

<?php if (isset($_POST['name'], $_POST['age'], $_POST['sex'])):?>
    <p>
        My name is <?= htmlentities($_POST['name']) ?>. I am <?= htmlentities($_POST['age']) ?> years old. I am <?= htmlentities($_POST['sex']) ?>.
    </p>
<?php endif; ?>
</body>
</html>

