function biggerThanNeighbors(index, arr) {
    var middle = arr[index];
    var before = arr[index - 1];
    var after = arr[index + 1];
    if (middle==undefined) {
        console.log('invalid index');
    }
    if (middle!=undefined && (before==undefined || after==undefined)) {
        console.log('only one neighbor');
    }
    else {
        if (middle > before && middle > after) {
            console.log('bigger');
        }
        if (middle <= before || middle <= after) {
            console.log('not bigger');
        }
    }
}

biggerThanNeighbors(2, [1, 2, 3, 3, 5]);
biggerThanNeighbors(2, [1, 2, 5, 3, 4]);
biggerThanNeighbors(5, [1, 2, 5, 3, 4]);
biggerThanNeighbors(0, [1, 2, 5, 3, 4]);