function Solve(args) {
    var s = parseInt(args[0]); // 40 => 11
    var count = 0;

    for (var i = 0; i < s; i++) {
        for (var j = 0; j < s; j++) {
            for (var k = 0; k < s; k++) {
                var sum = i * 10 + j * 4 + k * 3;
                if (sum === s) {
                    count++;
                }
            }
        }
    }

    return count;
}

console.log(Solve(['7']));

console.log(Solve(['10']));

console.log(Solve(['40']));