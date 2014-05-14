function Solve(params) {
    var N = parseInt(params[0]);
    var answer = 0;
    var arr = [];
    for (var i = 1; i < params.length; i++) {
        arr[i - 1] = params[i] | 0;
    }
    console.log('arr: ' + arr.join(', '));
    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] <= arr[i + 1]) {
            answer++;
            while (arr[i] <= arr[i + 1]) {
                i++;
            }
            i--;
        } else if (arr[i] < arr[i - 1] && arr[i] > arr[i + 1]) {
            answer++;
        }
    }
    return answer;
}