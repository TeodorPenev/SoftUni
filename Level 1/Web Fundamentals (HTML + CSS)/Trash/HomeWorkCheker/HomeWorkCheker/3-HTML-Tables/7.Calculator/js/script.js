var expressionElement = document.getElementById('expression');

var addToExpression = function (num) {
	expressionElement.value += num;
}

var evaluateExpression = function () {
	var result = eval(expressionElement.value)
	expressionElement.value = result;
}

var clearExpression = function () {
	expressionElement.value = '';
}
