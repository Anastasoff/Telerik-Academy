function Solve(args) {
    var finalResult = 0;
    var funcs = {};
    var cmd = '';
    for (var i = 0; i < args.length; i++) {
        var hasDef = false;
        var inArr = false;
        var list = [];
        var tempVar = '';
        cmd = args[i];
        for (var j = 0; j < cmd.length; j++) {
            if (cmd.substr(j, 3) === 'def') {
                hasDef = true;
            } else if (cmd[j] === '[') {
                inArr = true;
            } else if (inArr && cmd[j] !== ']') {
                if (cmd[j] !== ' ' && cmd[j] !== ',') {
                    tempVar += cmd[j];
                    if (tempVar === '-' && cmd[j + 1] === ' ') {
                        tempVar = '';
                        continue;
                    }

                    if (cmd[j + 1] === ' ' || cmd[j + 1] === ',' || cmd[j + 1] === ']') {
                        list.push(tempVar);
                        tempVar = '';
                    }
                }
            }
        }
    }

    function calculate(operation, list) {
        var isAvg = false;
        var result = list[0];
        for (var i = 1; i < list.length; i++) {
            switch (operation) {
                case 'sum':
                    result += list[i];
                    break;
                case 'min':
                    {
                        if (result > list[i]) {
                            result = list[i];
                        }
                        break;
                    }
                case 'max':
                    {
                        if (result < list[i]) {
                            result = list[i];
                        }
                        break;
                    }
                case 'avg':
                    result += list[i];
                    isAvg = true;
                    break;
                default:
                    return 'Error';
            }
        }

        if (isAvg) {
            Math.floor(result /= list.length);
        }

        return result;
    }
}