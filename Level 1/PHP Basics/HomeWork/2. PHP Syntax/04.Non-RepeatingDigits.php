<?php
$input =247;
if ($input>101){
    for ($i = 0; $i < 10; $i++) {
    for ($j = 0; $j < 10; $j++) {
    for ($k = 0; $k < 10; $k++) {
        $num =(int)"$i$j$k";
if(($i!=0)&&($input>=$num)&&($i!=$j && $j!=$k && $i!=$k)){
        echo "$i$j$k, ";}
    }
    }
    }
}else{
    echo "no";
}
?>