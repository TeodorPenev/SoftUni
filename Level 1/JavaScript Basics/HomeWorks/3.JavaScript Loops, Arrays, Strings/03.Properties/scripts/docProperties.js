function displayProperties() {
    var result =[];
    for (var prop in document) {
        result.push(prop);
    }
    result.sort();
    console.log(result.join('\n'));
}

displayProperties();

