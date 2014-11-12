function findPalindromes(str) {
    var words =str.split(/[\s.]+/);
    var word = '';
    var palindromes = [];
     words = words.filter(Boolean);
    for (var i = 0; i < words.length; i++) {
        word = words[i].toLowerCase();
        if (word != word.split('').reverse().join('')) {
            continue;
        } else {
            palindromes.push(word);
        }
    }
    console.log(palindromes.join(', '));
}

findPalindromes('There is a man, his name was Bob.');