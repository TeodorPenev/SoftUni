function solve(arr) {
    var sum = [];
    var max = 0;
    var pos = 0;
    var countDash = 0;
    for (var i = 2; i < arr.length - 1; i++) {
        var a = arr[i];
        var price1Start = a.indexOf('<td>', 9);
        var price1End = a.indexOf('</td>', price1Start + 1);
        var price2Start = a.indexOf('<td>', price1End + 1);
        var price2End = a.indexOf('</td>', price2Start + 1);
        var price3Start = a.indexOf('<td>', price2End + 1);
        var price3End = a.indexOf('</td>', price3Start + 1);
        var priceA = a.substring(price1Start + 4, price1End);
        var priceB = a.substring(price2Start + 4, price2End);
        var priceC = a.substring(price3Start + 4, price3End);
        sum.push(priceA);
        sum.push(priceB);
        sum.push(priceC);
    }
    for (var j = 0; j < sum.length ; j += 3) {
        var sum1 = sum[j];
        var sum2 = sum[j + 1];
        var sum3 = sum[j + 2];
        if (sum1 === '-') {
            sum1 = 0;
        }
        if (sum2 === '-') {
            sum2 = 0;
        }
        if (sum3 === '-') {
            sum3 = 0;
        }
        var sum1F = parseFloat(sum1);
        var sum2F = parseFloat(sum2);
        var sum3F = parseFloat(sum3);

        var tempSum = parseFloat(sum1F + sum2F + sum3F);
        if (tempSum > max) {
            max = tempSum;
            pos = j;
        }

    }
    for (var k = 0; k < sum.length; k++) {
        if (sum[k] == '-') {
            countDash++;
        }
    }
    if (sum[pos]==='-') {
        delete sum[pos];
    }
    if (countDash == sum.length) {
        console.log('no data');
    } else {
        console.log(max + ' = ' + sum[pos] + ' + ' + sum[pos + 1] + ' + ' + sum[pos + 2]);
    }

}

solve([
    '<table>',
    '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
    '<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>',
    '<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>',
    '<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>',
    '</table>'
]);
solve([
        '<table>',
        '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
        '<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
        '</table>'
]
);
solve([
       '<table>',
'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
'<tr><td>Sofia</td><td>12850</td><td>-560</td><td>20833</td></tr>',
'<tr><td>Rousse</td><td>-</td><td>50000.0</td><td>-</td></tr>',
'<tr><td>Bourgas</td><td>25000</td><td>25000</td><td>-</td></tr>',
'</table>'
]
);