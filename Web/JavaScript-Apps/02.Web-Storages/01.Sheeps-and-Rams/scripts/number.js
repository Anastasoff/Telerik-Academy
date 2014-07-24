define(function () {
    'use strict';
    var number = (function () {
        var originalNumber;

        function makeUpNumber() {
            do {
                originalNumber = Math.floor(Math.random() * 8999 + 1000);
            }
            while (numberHasRepeatingDigits(originalNumber));

            return originalNumber;
        }

        function numberHasRepeatingDigits(number) {
            var used = ['0', '0', '0', '0'],
                numberArr = [],
                numberToString = number.toString(),
                i;

            for (i = 0; i < 4; i += 1) {
                numberArr.push(numberToString[i]);
            }

            used[0] = numberArr[0];

            for (i = 1; i < 4; i += 1) {

                for (var j = 0; j < 4; j += 1) {

                    if (numberArr[i] === used[j]) {
                        return true;
                    }
                }
                used[i] = numberArr[i];
            }

            return false;
        }

        function checkForMatch(userInputNumber) {
            var userNumber = userInputNumber,
                origUserNum = userInputNumber,
                originalNum = originalNumber.toString(),
                rams = 0,
                sheeps = 0;

            if (userNumber.length != 4) {
                return 'number has to be exactly 4 digits';
            }

            for (var i = 0; i < userNumber.length; i += 1) {
                for (var j = 0; j < originalNum.length; j += 1) {
                    if (i === j && userNumber[i] === originalNum[j]) {
                        userNumber[i] = '{';
                        originalNum[i] = '}';
                        rams++;
                        break;
                    }
                    else if (i !== j && userNumber[i] === originalNum[j]) {
                        userNumber[i] = '(';
                        originalNum[i] = ')';
                        sheeps++;
                        break;
                    }
                }
            }

            return {
                userNumber: origUserNum,
                rams: rams,
                sheeps: sheeps
            }
        }

        return {
            makeUpNumber: makeUpNumber,
            checkForMatch: checkForMatch
        }
    })();

    return number;
});