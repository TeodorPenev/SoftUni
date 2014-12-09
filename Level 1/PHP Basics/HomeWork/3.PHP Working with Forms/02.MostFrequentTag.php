</<!doctype html>
<head>
    <title>2.Most Frequent Taq</title>
</head>
<body>
<p>Enter Tags:</p>

<form action="" method="get">
<input type="text" name="tags"/>
<input type="submit" name="submit"/>
</form>
<?php
if(isset($_GET['submit'])){
    $input = $_GET['tags'];
    $tagsArr = explode(', ',"$input");
    $freqCount  = array_count_values($tagsArr);

    ksort($freqCount);
    foreach($freqCount as $key =>$value) {
        echo $key . ' : ' . $value . ' times<br>';
    }
    foreach($freqCount as $key =>$value) {
        echo '<p>Most Frequent Tag is: '.$key.'</p>';
        break;
    }

}
?>
</body>
</html>

