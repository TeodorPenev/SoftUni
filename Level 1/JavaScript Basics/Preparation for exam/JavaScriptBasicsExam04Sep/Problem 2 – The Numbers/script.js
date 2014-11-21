function solve(arr) {
    var symbols = arr[0];
    var nums = symbols.split(/[^0-9]+/);
    nums = nums.filter(Boolean);
    var leadZero = [];
    var result = [];
    var meaning = '';
    for (var i = 0; i < nums.length; i++) {
        var decToHex = d2H(nums[i]);
        leadZero.push(zeroPad(decToHex, 4));
        function d2H(d) { return (+d).toString(16).toUpperCase(); }
        function zeroPad(num, places) {
            var zero = places - num.toString().length + 1;
            return Array(+(zero > 0 && zero)).join("0") + num;
        }
    }
    for (var j = 0; j < leadZero.length; j++) {
        result.push('0x' + leadZero[j]);
        if (j < leadZero.length - 1) {
            meaning += result[j] + '-';
        } else {
            meaning += result[j];
        }
    }
    console.log(meaning);
}

solve(['5tffwj(//*7837xzc2---34rlxXP%$”.']);
solve(['482vMWo(*&^%$213;k!@41341((()&^>><///]42344p;e312']);
solve(['20']);
