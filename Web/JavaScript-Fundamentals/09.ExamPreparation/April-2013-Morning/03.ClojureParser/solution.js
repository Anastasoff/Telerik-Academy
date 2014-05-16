function Solve(inputs) {
    // asociativen masiv za definiraite funcii ili masiv kato opa6ka
    // opa6ka za rezultat
    var funcs = {};
    for (var i = 0; i < inputs.length; i++) {

        var command = inputs[i];
        for (var j = 1; j < command.length - 1; j++) {
            var currentDef = command.indexOf('def');
            if (currentDef >= 0) {
                var index = 'def'.length + 1; // !
                var funcName = '';
                var funcValue = 0;
                var inWord = false;
                while (true) {

                    if (command[index] !== ' ') {


                        inWord = true;
                    }

                    index++;

                    inWord = false;
                }


                while (command[index] !== ' ' && command[index] !== ')' && command[index] !== '(') {
                    funcValue += parseInt(command[index]);
                    index++;
                }

                funcs[funcName] = funcValue;

                j = index; // ? +- 1
            }


        }
    }

    return;
}
