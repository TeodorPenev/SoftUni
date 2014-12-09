</<!doctype html>
<html>
<head>
    <title> 01.PrintTags</title>
</head>
<body>
<p>Enter Tags:</p>
<form action="" method="get">
    <input type="text" name="words"></input>
    <input type="submit" name="submit">
</form>

<?php
if(isset($_GET['submit'])){
    $tags =$_GET['words'];
    $tagsArr = explode(', ',$tags);

    for ($i=0;$i<count($tagsArr);$i++){
        echo $i.' : '. $tagsArr[$i].'<br>';
    }
}
?>
</body>
</html>

