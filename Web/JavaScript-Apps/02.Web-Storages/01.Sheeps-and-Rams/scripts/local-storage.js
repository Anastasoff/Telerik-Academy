define(function () {
    'use strict';
    var local = (function () {
        var DEFAULT_KEY = 'sheeps-and-rams',
            gameHistory = [];

        function save(gameProgressInformation) {
            gameHistory.push(JSON.stringify(gameProgressInformation));
            localStorage.setItem(DEFAULT_KEY, gameHistory)
        }

        function load() {
            if (!localStorage.getItem(DEFAULT_KEY)) {
                return null;
            }

            var progressInfo = localStorage.getItem(DEFAULT_KEY);

            progressInfo = progressInfo.replace(new RegExp("},{", "gm"), '};{');
            progressInfo = progressInfo.split(';');

            var len = progressInfo.length;
            var resultArr = [];
            for (var i = 0; i < len; i += 1) {
                resultArr.push(JSON.parse(progressInfo[i]));
            }

            return {
                gameProgressInformation: resultArr
            }
        }

        function clear() {
            localStorage.clear();
        }

        return {
            save: save,
            load: load,
            clear: clear,
            DefaultKey: DEFAULT_KEY
        }
    })();

    return local;
});