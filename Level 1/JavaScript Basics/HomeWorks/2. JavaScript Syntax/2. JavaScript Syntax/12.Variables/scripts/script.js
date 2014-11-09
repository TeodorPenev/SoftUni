function variablesTypes(arr) {
    var name = arr[0];
    var age = arr[1];
    var isMale = arr[2];
    var food = arr[3];
    return (console.log('My name: ' + name + ' //type is ' + typeof (name) + '\n' + 'My age: ' + age + ' //type is ' + typeof (age) + '\n' + 'I am male: ' + isMale + ' //type is ' + typeof (isMale) + '\n' + 'My favorite foods are: ' + food + ' //type is ' + typeof (food)));
}

variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']])