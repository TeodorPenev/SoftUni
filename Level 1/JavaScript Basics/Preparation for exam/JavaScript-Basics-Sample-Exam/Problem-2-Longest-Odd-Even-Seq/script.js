function solve(arr) {
    var nums = arr[0].split(/[)( ]+/);
    nums = nums.filter(Boolean);
    var maxCount = 0;
    var count = 1;
    var even = nums[0] % 2 == 0;
    for (var i = 0; i < nums.length - 1; i++) {
        if (even == true) {
            if (nums[i + 1] % 2 != 0 || nums[i + 1] == 0) {
                count++;
                even = false;
            } else {
                if (count > maxCount)
                    maxCount = count;
                count = 1;
            }
        } else {
            if (even == false) {
                if (nums[i + 1] % 2 == 0 || nums[i + 1] == 0) {
                    count++;
                    even = true;
                } else {
                    if (count > maxCount)
                        maxCount = count;
                    count = 1;
                }
            }
        }
    }
    if (count > maxCount) {
        maxCount = count;
    }
    console.log(maxCount);
}

solve(['(3)(22)(-18)(55)(44)(3)(21)']);
solve(['(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)']);
solve(['(2)(33)(1)(4)(-1)']);
solve(['(102)(103)(0)(105)(107)(1)']);
solve(['(2)(2)(2)(2)(2)']);

