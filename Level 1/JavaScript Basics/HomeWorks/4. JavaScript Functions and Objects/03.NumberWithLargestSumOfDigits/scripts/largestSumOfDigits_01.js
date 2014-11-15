function findLargestBySumOfDigits(arr) {
    var max = 0;
    var pos = 0;
    var arrTemp = [];
    for (var i = 0; i < arr.length; i++) {
       arrTemp[i] = Math.abs(arr[i]);
        if (arrTemp[i]>9 && arrTemp[i]<100 ) {
            var tempF = String(arrTemp[i]);
            var tempSum = parseInt(tempF[0]) + parseInt(tempF[1]);
            if (tempSum>max) {
                max = tempSum;
                pos = i;
            }
        }
        if (arr[i]> 99) {
            var tempS = String(arrTemp[i]);
            tempSum = parseInt(tempS[0]) + parseInt(tempS[1]) + parseInt(tempS[2]);
            if (tempSum > max) {
                max = tempSum;
                pos = i;
            }
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