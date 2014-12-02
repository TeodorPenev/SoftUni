</<!doctype html>
<head>
    <meta charset="UTF-8">
    <title>Lazy Sundays</title>
</head>
<body>
<?php
$startDate = strtotime("Sunday");
$month = date("m",$startDate);
$year = date("Y",$startDate);
$endDate =mktime(1,1,1,$month+1,1,$year);
while($startDate<$endDate){
    echo date("jS F, Y", $startDate);?>
    <br>
<?php
    $startDate=strtotime("+1 Week",$startDate);
}
?>
</body>
</html>

