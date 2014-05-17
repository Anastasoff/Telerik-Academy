function Solve(args) {
    function CreateField(rows, cols) {
        var matrix = [],
            counter = 1;

        for (var row = 0; row < rows; row++) {
            matrix[row] = [];
            for (var col = 0; col < cols; col++) {
                matrix[row][col] = counter;
                counter++;
            }
        }

        return matrix;
    }

    var numbers = args[0].split(' '),
        rows = parseInt(numbers[0]), // N
        cols = parseInt(numbers[1]), // M
        jumbs = parseInt(numbers[2]); // J

    var positions = args[1].split(' '),
        row = parseInt(positions[0]), // R
        col = parseInt(positions[1]); // C

    var field = CreateField(rows, cols),
        escaped = false,
        caught = false,
        result = 0,
        sumOfNumbers = field[row][col],
        numberOfJumbs = 0;

    while (escaped !== true && caught !== true) {
        for (var i = 0; i < jumbs; i++) {
            var currentPosition = args[2 + i].split(' ');
            row += parseInt(currentPosition[0]);
            col += parseInt(currentPosition[1]);

            // check if escaped
            if ((row < 0 || row >= field.length) || (col < 0 || col >= field[row].length)) {
                escaped = true;
                result = sumOfNumbers;
                break;
            }

            // check if caught
            if (field[row][col] === -1) {
                caught = true;
                result = numberOfJumbs;
                break;
            }

            sumOfNumbers += field[row][col];
            numberOfJumbs++;
            field[row][col] = -1;
        }
    }

    if (escaped === true) {
        return 'escaped ' + result;
    } else {
        return 'caught ' + result;
    }
}