define(['jquery'], function ($) {
    'use strict';
    var drawer = (function () {
        function visualiseGame(loadedInfo) {
            if (!loadedInfo) {
                loadInitialSetUp();
            }
            else {
                loadInitialSetUp();
                parseLoadedInfo(loadedInfo);
            }
        }

        function parseLoadedInfo(loadedInfo) {
            var $resultList = $('<ul/>');
            for (var item in loadedInfo.gameProgressInformation) {
                if (item == 0) {
                    continue;
                }

                var $currentListItem = $('<li/>')
                    .append(
                        'Number: ' + loadedInfo.gameProgressInformation[item].userNumber +
                        '; Rams: ' + loadedInfo.gameProgressInformation[item].rams +
                        ' vs Sheeps: ' + loadedInfo.gameProgressInformation[item].sheeps
                );
                $resultList.append($currentListItem);
            }

            $resultList.appendTo('#gameInfo');
        }

        function loadInitialSetUp() {
            var $container = $('#container');
            $container.html('<p>Guess 4 digits!</p>');

            var $inputTextBox = $('<input id="userGuessNumber" type="text"/>'),
                $inputButton = $('<input id="userGuessNumberBtn" type="button" value="Guess"/>'),
                $gameInfo = $('<div id="gameInfo"> </div>');

            $container
                .append($inputTextBox)
                .append($inputButton)
                .append($gameInfo);
        }

        return {
            visualiseGame: visualiseGame
        }
    })();

    return drawer;
});