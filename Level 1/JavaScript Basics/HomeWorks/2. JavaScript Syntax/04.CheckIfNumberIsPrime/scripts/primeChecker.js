function isPrime(number) {
    var start = 2;
    while (start <= Math.sqrt(number)) {
        if (number % start++ < 1)
            return false;
    }
    return true;
}

console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));