function findNthDigit(arr) {
    var pos = arr[0];
    var num =String(Math.abs(arr[1])).replace('.','');
    var result = num[num.length - pos];
    if (result==undefined) {
        console.log('undefined ');
    } else {
        console.log(result);
    }
}

findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);
