function calcSupply(age,maxAge,food,foodPerDay) {
    var restDay = (maxAge - age)*365;
    var restFood = restDay * foodPerDay;
    return (console.log(restFood + "kg of " + food + " would be enough until I am " + maxAge + " year old."));
}

calcSupply(38, 118, 'chocolate', 0.5);
calcSupply(20, 87, 'fruits', 2);
calcSupply(16, 102, 'nuts', 1.1);

