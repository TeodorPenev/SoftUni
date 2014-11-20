function solve(arr) {
    var words = arr[0].split(' ');
    var sequence = [];
    var count = 1;
    var undef = 0;
    while (undef < words.length) {
        for (var j = 0; j < words.length; j++) {
            var tempWord = words[j % words.length];
            if (tempWord[words[j % words.length].length - count] != undefined) {
                sequence.push(tempWord[words[j % words.length].length - count]);
            } else {
                undef++;
            }
        }
        count++;
    }
    for (var i = 0; i < sequence.length; i++) {
        var tempChar = sequence[i];
        var temPos = tempChar.toLowerCase().charCodeAt(0);
        var moves = temPos - 97 + 1;
        var newMoves = (i + moves) % (sequence.length);
        sequence.splice(i, 1);
        sequence.splice(newMoves, 0, tempChar);
    }
    console.log(sequence.join(''));
}

solve(['Fun exam right']);