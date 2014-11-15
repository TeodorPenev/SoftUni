function checkDigit(number) {
    var result = Math.floor(number / 100) % 10;
    if (result==3) {
        return (console.log(true));
    } else {
        return (console.log(false));
    }
}

checkDigit(1235);
checkDigit(25368);
checkDigit(123456);