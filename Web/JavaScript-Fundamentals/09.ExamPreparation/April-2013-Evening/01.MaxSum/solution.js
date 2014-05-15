function Solve(params) {
    var N = parseInt(params[0]),
        maxSum = parseInt(params[1]),
        tempSum = parseInt(params[1]);
    for (var i = 2; i <= N; i++) {
        var current = parseInt(params[i]);
        if (tempSum < 0) {
            tempSum = current;
        } else {
            tempSum += current;
        }

        if (tempSum > maxSum) {
            maxSum = tempSum;
        }
    }

    return maxSum;
}