function reverseWordsInString(str) {
    var arr = str.split(/[\s]/);
    var rev = '';
    for (var i = 0; i < arr.length; i++) {
        var tempWord = arr[i];
        rev = rev + " " + tempWord.split('').reverse().join('');
    }
    console.log((rev).trim());
}

reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good, isn’t it?');
