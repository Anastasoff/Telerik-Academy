define(['jquery', './gameEngine'], function ($, Game) {
    var Sudoku = (function (gameEngine) {
        var _instance,
            _game,
            defaultConfig = {
                'validate_on_insert': true,
                'show_solver_timer': true,
                'show_recursion_counter': true,
                'solver_shuffle_numbers': true
            };

        function init(config) {
            var conf = $.extend({}, defaultConfig, config);
            _game = new gameEngine.Game(conf);

            return {
                getGameBoard: function () {
                    return _game.buildGUI();
                },

                reset: function () {
                    _game.resetGame();
                },

                validate: function () {
                    var isValid;

                    isValid = _game.validateMatrix();
                    $('.sudoku-container').toggleClass('valid-matrix', isValid);
                },

                solve: function () {
                    var isValid,
                        startTime,
                        endTime,
                        elapsed;

                    if (!_game.validateMatrix()) {
                        return false;
                    }

                    _game.recursionCounter = 0;
                    _game.backtrackCounter = 0;

                    startTime = Date.now();

                    isValid = _game.solveGame(0, 0);

                    endTime = Date.now();

                    $('.sudoku-container').toggleClass('valid-matrix', isValid);
                    if (isValid) {
                        $('.valid-matrix input').attr('disabled', 'disabled');
                    }

                    if (_game.config.show_solver_timer) {
                        elapsed = endTime - startTime;
                        window.console.log('Solver elapsed time: ' + elapsed + 'ms');
                    }

                    if (_game.config.show_recursion_counter) {
                        window.console.log('Solver recursions: ' + _game.recursionCounter);
                        window.console.log('Solver backtracks: ' + _game.backtrackCounter);
                    }
                }
            };
        }

        return {
            getInstance: function (config) {
                if (!_instance) {
                    _instance = init(config);
                }
                return _instance;
            }
        };
    }(Game));

    return Sudoku;
});