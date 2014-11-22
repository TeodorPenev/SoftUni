function solve(arr) {
    var start = parseInt(arr[0]);
    var end = parseInt(arr[1]);
    var first = [];
    var second = [];
    var third = [];
    var isFib = [];
    var isYes = false;
    var endLength = end - start + 1;
    for (var i = start; i <= end; i++) {
        first.push(i);
        second.push(i * i);
    }
    for (var j = 0; j <= end; j++) {
        third.push(fib(j));
        if (fib(j) > end) {
            break;
        }

        function fib(n) {
            return n < 2 ? n : fib(n - 1) + fib(n - 2);
        };
    }
    for (var k = 0; k < first.length; k++) {
        for (var l = 0; l < third.length; l++) {
            if (first[k] == third[l]) {
                isFib.push('yes');
                isYes = true;
                break;
            }
        }
        if (isYes == false) {
            isFib.push('no');
        }
        isYes = false;
    }

    console.log('<table>');
    console.log('<tr><th>Num</th><th>Square</th><th>Fib</th></tr>');
    for (var m = 0; m < endLength; m++) {
        console.log('<tr><td>'+first[m]+'</td><td>'+second[m]+'</td><td>'+isFib[m]+'</td></tr>');
    }
    console.log('</table>');
}

solve(['5', '10']);
