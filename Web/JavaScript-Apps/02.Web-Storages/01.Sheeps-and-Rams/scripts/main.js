define(['jquery', './drawer', './number', './local-storage'], function ($, drawer, number, local) {
    'use strict';

    var $container = $('#container');
    $container.on('click', '#startNewGame', startNewGame);
    $container.on('click', '#continueOldGame', continueOldGame);
    $container.on('click', '#clearStorage', clearStorage);
    $container.on('click', '#userGuessNumberBtn', passGuess);

    function startNewGame() {
        var computerNumber = number.makeUpNumber();
        local.save({computerNumber: computerNumber});
        drawer.visualiseGame();
    }

    function continueOldGame() {
        var loadedInfo = local.load();
        if (loadedInfo === null) {
            $('#container').html('<p>F5 for new game</p>');
        }
        else {
            drawer.visualiseGame(loadedInfo);
        }
    }

    function clearStorage() {
        local.clear();
    }

    function passGuess() {
        var $guessNumber = $container
            .find('#userGuessNumber')
            .val();

        var intRegex = /[1-9]{4}/;

        if ($guessNumber.length == 4 && intRegex.test($guessNumber)) {
            $('#container').find('#warning').remove();

            var guessResult = number.checkForMatch($guessNumber);

            var currentGuess =
                '<p>Number: ' + guessResult.userNumber +
                '; Rams: ' + guessResult.rams +
                ' vs Sheeps: ' + guessResult.sheeps + '</p>';

            $container.append(currentGuess);

            local.save(guessResult);
        }
        else {
            var $warning = $('<p id="warning">Invalid input!</p>');
            $container.find('#warning').remove();
            $container.append($warning);
        }
    }

});