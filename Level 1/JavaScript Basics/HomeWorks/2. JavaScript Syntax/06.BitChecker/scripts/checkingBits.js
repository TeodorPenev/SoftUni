function bitChecker(number) {
    var strNum = number.toString(2);
    var strRev = strNum.split('').reverse().join('');
    var result = strRev[3];
    if (result==1) {
        console.log(true);
    } else {
        console.log(false);
    }
}

bitChecker(333);
bitChecker(425);
bitChecker(2567564754);