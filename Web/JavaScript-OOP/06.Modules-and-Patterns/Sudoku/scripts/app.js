(function () {
    'use strict';
    require.config({
        paths: {
            'jquery': 'bower_components/jquery/dist/jquery'
        }
    });

    require(['jquery', './sudoku'], function ($, Sudoku) {
        var game = Sudoku.getInstance();
        $('#container').append(game.getGameBoard());

        $('#solve').click(function () {
            game.solve();
        });
        $('#validate').click(function () {
            game.validate();
        });
        $('#reset').click(function () {
            game.reset();
        });
    });
}());