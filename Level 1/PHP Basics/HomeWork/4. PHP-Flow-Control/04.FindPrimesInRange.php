<!DOCTYPE html>
<html>
<head>
    <title>04.Find Primes in Range</title>
</head>
<body>

<form action="" method="GET">
    <label for="start">Starting index: </label>
    <input type="text" id="start" name="start" />
    <label for="end">End: </label>
    <input type="text" id="end" name="end" />
    <input type="submit" name="submit" value="Submit" />
</form>

<div id="result">
    <?php


    if($_GET && isset($_GET['submit'])) {
        $start = $_GET['start'];
        $end = $_GET['end'];
        if($start < $end) {
            $result = array();
            for($i = $start; $i <= $end; $i++) {
                if(isPrime($i)) {
                    $result[] = '<strong>' . $i . '</strong>';
                } else {
                    $result[] = '<span>' . $i . '</span>';
                }
            }
            echo implode(", ", $result);
        } else {
            echo "Invalid data!";
        }
    }
    ?>

    <?php
    function isPrime($num) {
        if($num == 1) {
            return false;
        }
        if($num == 2) {
            return true;
        }
        if($num % 2 == 0) {
            return false;
        }
        for($i = 3; $i <= sqrt($num); $i = $i + 2) {
            if($num % $i == 0)
                return false;
        }
        return true;
    }
    ?>
</div>

</body>
</html>