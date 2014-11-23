function solve(arr) {
    var start = arr[0];
    var end = arr[1];
    var nums = [];
    var first1 = [];
    var second1 = [];
    var firstDouble = '';
    for (var i = start; i <= end; i++) {
        nums.push(i);
    }

    for (var j = 0; j < nums.length; j++) {
        if (nums[nums[j].length] < 3) {
            break;
        } else {
            for (var k = 0; k < nums.length - 3; k++) {
                firstDouble =nums[j][k].toString() + nums[j][k + 1].toString();
                for (var l = 0; l < nums[j].length - 1; l++) {
                    var secondDouble = nums[j][k+l + 2] + nums[j][k+l + 3]
                    if (firstDouble == secondDouble) {
                        console.log('Yes');
                    };
                };
                
            }
        }
    }

}



//solve(['5', '8']);
solve(['11210', '11215'])