function findMaxSequence(arr) {
    var count = 1;
    var maxSymbol = arr[0];
    var max =1;
    var maxSeqArr = [];
    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] === arr[i + 1]) {
            count++;
        } else {
            if (count>=max) {
                max = count;
                maxSymbol = arr[i];
                count = 1;
            }
        }
    }

    for (var j = 0; j < max; j++) {
        maxSeqArr[j] = maxSymbol;
    }

    console.log(maxSeqArr.join(', '));
}

findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);