define(['jquery', 'gameEngine'], function ($, Game) {
    'use strict';
    var Sudoku;

    Sudoku = (function (gameEngine) {
        var _instance,
            _game,
            _defaultConfig = {
                'validate_on_insert': true,
                'show_solver_timer': true,
                'show_recursion_counter': true,
                'solver_shuffle_numbers': true
            };

        function Sudoku(config) {
            var conf = $.extend({}, _defaultConfig, config);
            _game = new gameEngine.Game(conf);
        }

        Sudoku.prototype = {
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

        return {
            getInstance: function (config) {
                if (!_instance) {
                    _instance = new Sudoku(config);
                }
                return _instance;
            }
        };
    }(Game));

    return Sudoku;
});