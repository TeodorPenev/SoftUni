function solve(arr) {
    var exist = false;
    var words = arr[0].split(/[^a-zA-Z]+/);
    var result = [];
    words =words.filter(Boolean);
    for (var a = 0; a < words.length; a++) {
        for (var b = 0; b < words.length; b++) {
            if (a != b) {
                var concatWords = words[a] + words[b];
                for (var c = 0; c < words.length; c++) {
                    if (concatWords === words[c]) {
                        var find = words[a] + '|' + words[b] + '=' + words[c];
                        if (result.indexOf(find)<0) {
                        result.push(words[a] + '|' + words[b] + '=' + words[c]);
                        exist = true;
                        }
                        
                    }
                }
            }
        }
    }
    if (exist==false) {
        console.log('No');
    } else {
        console.log(result.join('\n'));
    }

}

solve(['java..?|basics/*-+=javabasics']);
solve(['Hi, Hi, Hihi']);
solve(['Uni(lo,.ve=I love SoftUni (Soft)']);
solve(['a a aa a']);
solve(['x a ab b aba a hello+java a b aaaaa']);
solve(['aa bb bbaa']);
solve(['ho hoho']);