function solve(arr) {
    var bill = arr[0];
    var mood = arr[1];
    var tip = 0;
    if (mood == 'happy' || mood == 'married' || mood == 'drunk') {
        if (mood == 'happy') {
            tip = bill * 0.10;
        }
        if (mood == 'married') {
            tip = bill * 0.0005;
        }
        if (mood == 'drunk') {
            var firstDigit = parseInt(bill[0]);
            var tempTip = (bill * 0.15);
            tip = Math.pow(tempTip, firstDigit);
        }
    } else {
        tip = bill * 0.05;
    }
    console.log(tip.toFixed(2));
}

solve(['9999.13', 'drunk']);
solve(['1230.83', 'drunk']);
solve(['716.00', 'bored']);
