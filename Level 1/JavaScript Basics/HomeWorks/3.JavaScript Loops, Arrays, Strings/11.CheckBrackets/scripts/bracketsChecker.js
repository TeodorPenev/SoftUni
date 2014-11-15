function checkBrackets(str) {
    var bracketsArr = str.split(' ');
    var countCloseB = 0;
    var countOpenB = 0;
    var isIncorrect = false;
    for (var i = 0; i < bracketsArr.length; i++) {
        if (bracketsArr[i]==')' && countOpenB==0) {
            console.log('incorrect');
            isIncorrect = true;
            break;
        } else {
            if (bracketsArr[i]=='(') {
                countOpenB++;
            }if(bracketsArr[i]==')') {
                countCloseB++;
            }
        }
    }
    if (countOpenB==countCloseB && isIncorrect==false) {
        console.log('correct');
    } else if (isIncorrect==false) {
        console.log('incorrect');
    }
}

checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');
