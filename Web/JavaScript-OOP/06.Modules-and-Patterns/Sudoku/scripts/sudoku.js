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
                    if (isValid) {
                        $('.sudoku-container').toggleClass('valid-matrix');
                    } else {
                        $('.sudoku-container').toggleClass('invalid-matrix');
                    }
                },

                solve: function () {
                    var isValid;

                    if (!_game.validateMatrix()) {
                        return false;
                    }

                    isValid = _game.solveGame(0, 0);

                    $('.sudoku-container').toggleClass('valid-matrix', isValid);
                    if (isValid) {
                        $('.valid-matrix input').attr('disabled', 'disabled');
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