function printNumbers(number) {
    var result = [];
    if (number>0) {
        for (var i = 1; i <= number; i++) {
            if (i % 4 == 0 || i % 5 == 0) {
                continue;
            } else {
                result.push(i);
            }
        }
        return (result);
    } else {
        return 'no';
    }
}

jsConsole.writeLine(printNumbers(20).join(', '));
jsConsole.writeLine(printNumbers(-5));
jsConsole.writeLine(printNumbers(13).join(', '));