function Solve(args) {
    function createMatrix(rows, cols) {
        var matrix = [];
        var couter;
        for (var i = 0; i < rows; i++) {
            matrix[i] = [];
            couter = Math.pow(2, i);
            for (var j = 0; j < cols; j++) {
                matrix[i][j] = couter++;
            }
        }

        return matrix;
    }

    function createSteps(steps) {
        var matrix = [];
        for (var i = 0; i < steps.length; i++) {
            var current = steps[i].split(' ');
            matrix[i] = [];
            for (var j = 0; j < current.length; j++) {
                var temp = current[j];
                matrix[i][j] = temp;
            }
        }

        return matrix;
    }

    var position = args[0].split(' ').map(Number);
    var rows = position[0];
    var cols = position[1];
    var matrix = createMatrix(rows, cols);
    var totalSum = 0;
    var steps = args.splice(1);
    var stepsMatrix = createSteps(steps);
    var cmd = '';
    for (var row = 0; row < rows;) {
        for (var col = 0; col < cols;) {
            cmd = stepsMatrix[row][col];
            var tempRow = row;
            var tempCol = col;

            if (matrix[row][col] === -1) {
                return 'failed at (' + row + ', ' + col + ')';
            }

            if (cmd === 'dr') { // down-right                
                totalSum += matrix[row++][col++];
            } else if (cmd === 'ur') { // up-right
                totalSum += matrix[row--][col++];
            }
            else if (cmd === 'ul') { // up-left
                totalSum += matrix[row--][col--];
            }
            else if (cmd === 'dl') { // down-left
                totalSum += matrix[row++][col--];
            }

            matrix[tempRow][tempCol] = -1;

            if (row < 0 || row >= rows || col < 0 || col >= cols) {
                return 'successed with ' + totalSum;
            }
        }
    }

}

args1 = [
  '3 5',
  'dr dl dr ur ul',
  'dr dr ul ur ur',
  'dl dr ur dl ur'
];

console.log(Solve(args1));

args2 = [
  '3 5',
  'dr dl dl ur ul',
  'dr dr ul ul ur',
  'dl dr ur dl ur'
];

console.log(Solve(args2));
