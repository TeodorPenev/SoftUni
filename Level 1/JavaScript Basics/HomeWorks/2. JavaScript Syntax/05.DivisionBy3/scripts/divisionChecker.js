function divisionBy3(number) {
    if (number < 100) {
        var firstDigitF = Math.floor(number / 10);
        var secondDigitF = number % 10;
        var sumF = firstDigitF + secondDigitF;
        if (sumF % 3 == 0) {
            console.log('the number is divided by 3 without remainder');
        } else {
            console.log('the number is not divided by 3 without remainder');
        }
    }

    if (number >= 100) {
        var firstDigitS = Math.floor(number / 100);
        var secondDigitS = Math.floor(number / 10) % 10;
        var thirdDigitS = Math.floor(number % 10);

        var sumS = firstDigitS + secondDigitS + thirdDigitS;
        if (sumS % 3 == 0) {
            console.log('the number is divided by 3 without remainder');
        } else {
            console.log('the number is not divided by 3 without remainder');
        }
    }
}

divisionBy3(12);
divisionBy3(188);
divisionBy3(591);