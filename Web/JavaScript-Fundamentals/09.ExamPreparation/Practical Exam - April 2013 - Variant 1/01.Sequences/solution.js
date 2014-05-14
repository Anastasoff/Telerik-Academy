function Solve(params) {
    var N = parseInt(params[0]);
    var answer = 1;
    var temp = parseInt(params[1]);
    for (var i = 2; i <= N; i++) {
        var current = parseInt(params[i]);
        if (answer < temp) {
            answer++;
        }

        temp = current;
    }
    return answer;
}