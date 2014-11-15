function findLargestBySumOfDigits(arr) {
    var max = 0;
    var pos = 0;
    var arrTemp = [];
    var tempSum = 0;
    for (var i = 0; i < arr.length; i++) {
        arrTemp[i] = Math.abs(arr[i]);
        if (arrTemp[i]>9) {
            var tempF = String(arrTemp[i]);
            for (var j = 0; j < tempF.length; j++) {
                tempSum = parseInt(tempSum) + parseInt(tempF[j]);
                if (tempSum > max) {
                    max = tempSum;
                    pos = i;
                }
            }
            tempSum = 0;
        }
    }
    if (max > 1) {
        console.log(arr[pos]);
    } else {
        console.log(undefined);
    }
}

findLargestBySumOfDigits([5, 10, 15, 111]);
findLargestBySumOfDigits([33, 44, -99, 0, 20]);
findLargestBySumOfDigits(['hello']);
findLargestBySumOfDigits([5, 3.3]);