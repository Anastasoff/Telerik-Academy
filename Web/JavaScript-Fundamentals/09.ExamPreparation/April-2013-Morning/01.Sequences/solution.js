function Solve(params) {
    var N = parseInt(params[0]),
        numberOfSequences = 1,
        tempNumber = parseInt(params[1]);

    for (var i = 2; i <= N; i++) {
        var current = parseInt(params[i]);
        if (current < tempNumber) {
            numberOfSequences++;
        }

        tempNumber = current;
    }

    return numberOfSequences;
}