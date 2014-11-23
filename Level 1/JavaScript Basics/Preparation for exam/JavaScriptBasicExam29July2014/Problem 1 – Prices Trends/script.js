function solve(arr) {
    var price = [];
    var trend = ['fixed'];

    for (var j = 0; j < arr.length; j++) {
        var tempNum = parseFloat(arr[j]);
        var fixedTo2 = tempNum.toFixed(2);
        price.push(fixedTo2);
    }

    for (var i = 0; i < arr.length - 1; i++) {
        if (price[i] < price[i + 1]) {
            trend.push('up');
            continue;
        }
        if (price[i] > price[i + 1]) {
            trend.push('down');
            continue;
        }
        if ((price[i] == price[i + 1])) {
            trend.push('fixed');
            continue;
        }
    }
    console.log('<table>');
    console.log('<tr><th>Price</th><th>Trend</th></tr>');
    for (var k = 0; k < arr.length; k++) {
        console.log('<tr><td>'+price[k]+'</td><td><img src="'+trend[k]+'.png"/></td></td>');
    }
    console.log('</table>');
}

solve(['50', '60']);
solve(['36.333', '36.5', '37.019', '35.4', '35', '35.001', '36.225']);