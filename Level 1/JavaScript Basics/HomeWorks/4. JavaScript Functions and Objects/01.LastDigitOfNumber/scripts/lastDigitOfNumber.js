﻿function lastDigitAsText(number) {
    var lastDigit = Math.abs(number % 10);
    switch (lastDigit) {
        case 0:
            console.log('Zero'); break;
        case 1:
            console.log('One'); break;
        case 2:
            console.log('Two'); break;
        case 3:
            console.log('Three'); break;
        case 4:
            console.log('Four'); break;
        case 5:
            console.log('Five'); break;
        case 6:
            console.log('Six'); break;
        case 7:
            console.log('Seven'); break;
        case 8:
            console.log('Eight'); break;
        case 9:
            console.log('Nine'); break;
        default:
            console.log('Not a number!');
    }
}

lastDigitAsText(6); 
lastDigitAsText(-55);
lastDigitAsText(133);
lastDigitAsText(14567);
