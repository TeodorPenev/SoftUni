function findYoungestPerson(persons) {
    var min = 100;
    var youngest = 0;
    for (var people in persons) {
        var age = persons[people].age;
        if (min > age) {
            min = age;
            youngest = people;
        }
    }
    console.log('The youngest person is ' + persons[youngest].firstname + ' ' + persons[youngest].lastname);
}

var persons = [
    { firstname: 'George', lastname: 'Kolev', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Baba', lastname: 'Ginka', age: 40 }
];
findYoungestPerson(persons);
