function findMinAndMax(arr) {
    var min = Number.MAX_VALUE;
    var max = Number.MIN_VALUE;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i]<min) {
            min = arr[i];
        }
        if (arr[i]>max) {
            max = arr[i];
        }
    }
    return ('Min -> ' + min + '\n' + 'Max -> '+max);
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));
