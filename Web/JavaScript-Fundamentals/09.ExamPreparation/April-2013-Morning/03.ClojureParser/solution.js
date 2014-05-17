﻿function Solve(inputs) {
    function calculateExpression(expression) {
        var result = 0,
            values = [],
            i,
            operator;

        // find operator
        if (expression.indexOf('+') > 0) {
            operator = '+';
        } else if (expression.indexOf('-') > 0) {
            operator = '-';
        } else if (expression.indexOf('*') > 0) {
            operator = '*';
        } else if (expression.indexOf('/') > 0) {
            operator = '/';
        }

        for (i = expression.indexOf(operator) + 1; i < expression.length - 1; i++) {
            if (expression[i] !== ' ' && expression[i] !== ')') {
                var tempStr = '';

                while (expression[i] !== ' ' && expression[i] !== ')') {
                    tempStr += expression[i];
                    i++;
                }

                var value = parseInt(tempStr);
                if (isNaN(value)) {
                    for (var f in funcs) {
                        if (tempStr === f) {
                            value = parseInt(funcs[f]);
                        }
                    }
                }

                values.push(value);
                i--;
            }
        }

        result = values[0];
        if (operator === '+') {
            for (i = 1; i < values.length; i++) {
                result += values[i];
            }
        } else if (operator === '-') {
            for (i = 1; i < values.length; i++) {
                result -= values[i];
            }
        } else if (operator === '*') {
            for (i = 1; i < values.length; i++) {
                result *= values[i];
            }
        } else if (operator === '/') {
            for (i = 1; i < values.length; i++) {
                if (values[i] === 0) {
                    hasZeroDivision = true;
                    break;
                }
                result /= values[i];
            }

            result = Math.floor(result);
        }

        return result;
    }

    var output,
        funcs = {};
    var tempOutput = 0;
    var hasZeroDivision = false;
    var lineNumber = 0;
    for (var j = 0; j < inputs.length; j++) {
        var command = inputs[j];
        var defIndex = command.indexOf('def');
        if (defIndex > 0) {
            var funcName = '';
            var funcValue = 0;
            var index = defIndex + 3;

            // get function name
            while (true) {
                if (command[index] !== ' ') {
                    funcName += command[index];
                    if (command[index + 1] === ' ') {
                        index++;
                        break;
                    }
                }
                index++;
            }

            // get value or expression
            var tempValue = '';
            while (true) {
                if (command[index] !== ' ' && command[index] !== '(') {
                    tempValue = command.substring(index, command.length - 1).trim();
                    funcValue = parseInt(tempValue);
                    break;
                }

                if (command[index] === '(') {
                    tempValue = command.substring(index, command.length - 1).trim();
                    funcValue = calculateExpression(tempValue);
                    break;
                }

                index++;
            }

            funcs[funcName] = funcValue;
        } else {
            tempOutput += calculateExpression(command);
        }

        if (hasZeroDivision) {
            lineNumber = j + 1;
            break;
        }
    }

    // !!!
    output = tempOutput;
    if (hasZeroDivision === false) {
        return output;
    } else {
        return 'Division by zero! At Line:' + lineNumber;
    }
}