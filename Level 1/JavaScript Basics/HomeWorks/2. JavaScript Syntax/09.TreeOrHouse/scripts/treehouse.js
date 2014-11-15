function treeHouseCompare(arr) {
    var squareSide = arr[0];
    var squareArea = Math.pow(squareSide, 2);
    var triangleArea = 0.5 * squareSide * (squareSide * 2/3);
    var houseArea = squareArea + triangleArea;

    var rectangleSide = arr[1];
    var rectangleArea = arr[1] * arr[1]/3;
    var radius = rectangleSide *2/3;
    var circleArea = Math.PI * Math.pow(radius, 2);
    var treeArea = rectangleArea + circleArea;

    if (houseArea>treeArea) {
        console.log("house/" + houseArea.toFixed(2));
    } else {
        console.log("tree/" + treeArea.toFixed(2));
    }
}

treeHouseCompare([3, 2]);
treeHouseCompare([3, 3]);
treeHouseCompare([4, 5]);