function findMaxSequence(arr) {
    var max = 0;
    var pos = 0;
    var count = 0;
    var maxSeqArr = [];
    var exist = true;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] < arr[i + 1]) {
            count++;
        } else {
            if (max < count) {
                max = count;
                pos = i - count;
                count = 0;
            } else {
                count = 0;
            }
        }
    }
    if (max>0) {
        for (var j = pos, k = 0; j <= pos + max; j++, k++) {
            maxSeqArr[k] = arr[j];
        }
    } else {
        exist = false;
        console.log('[no]');
    }

    if (exist) {
        console.log('[' + maxSeqArr.join(', ') + ']');
    }
    
}

findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);