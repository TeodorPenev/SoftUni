</<!doctype html>
<html>
<head>
    <title>3.Calculate Interest</title>
</head>
<body>
<form action="" method="post">
    <label for="amount">Enter Amount</label>
    <input type="text" name="amount" id="amount"/><br>
    <input type="radio" name="currency" value="USD"/>USD
    <input type="radio" name="currency" value="EUR"/>EUR
    <input type="radio" name="currency" value="BGN"/>BGN<br>
    <label for="interest">Compound Interest Amount</label>
    <input type="text" name="interest" id="interest"/><br>
    <select name="period">
        <option value="6">6 Mounths</option>
        <option value="12">1 Year</option>
        <option value="24">2 Year</option>
        <option value="60">5 Year</option>
    </select>
    </select>
    <input type="submit" name="submit" value="Calculate">
</form>
<?php
if(isset($_POST['submit'])){
    $amount = $_POST['amount'];
    $currency = $_POST['currency'];
    $interest = $_POST['interest'];
    $period = $_POST['period'];

    $intPerM = ($interest/12 + 100)/100;
    $finalAmount =0;

for($i=0;$i<$period;$i++){
      $finalAmount =$amount*$intPerM;
    $amount=$finalAmount;
  }
    $finalAmount = number_format($finalAmount, 2, '.', '');
    if($currency=='BGN'){
        echo $finalAmount.' лв.';
    }
    if($currency=='USD'){
        echo '$ '.$finalAmount;
    }
    if($currency=='EUR'){
        echo '€ '.$finalAmount;
    }
}
?>
</body>
</html>