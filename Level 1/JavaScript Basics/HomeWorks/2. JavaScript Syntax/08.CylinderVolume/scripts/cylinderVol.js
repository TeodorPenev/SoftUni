function calcCylinderVol(arr) {
    var radius = arr[0];
    var height = arr[1];
    var result = (Math.PI * Math.pow(radius, 2) * height).toFixed(3);
    return console.log(result);
}

calcCylinderVol([2, 4]);
calcCylinderVol([5, 8]);
calcCylinderVol([12, 3]);