define(['jquery'], function ($) {
    'use strict';
    var Game;

    Game = (function () {
        function Game(config) {
            this._config = config;
            this._$cellMatrix = {};
            this._matrix = {};
            this._validation = {};
            this.resetValidationMatrices();
        }

        Game.prototype = {
            buildGUI: function () {
                var $td,
                    $tr,
                    $table = $('<table>')
                        .addClass('sudoku-container');

                for (var i = 0; i < 9; i++) {
                    $tr = $('<tr>');
                    this._$cellMatrix[i] = {};

                    for (var j = 0; j < 9; j++) {
                        this._$cellMatrix[i][j] = $('<input>')
                            .attr('maxlength', 1)
                            .attr('pattern', '\\d+')
                            .data('row', i)
                            .data('col', j)
                            .on('keyup', $.proxy(this.onKeyUp, this));

                        $td = $('<td>').append(this._$cellMatrix[i][j]);

                        var sectIDi = Math.floor(i / 3);
                        var sectIDj = Math.floor(j / 3);

                        if (( sectIDi + sectIDj ) % 2 === 0) {
                            $td.addClass('sudoku-section-one');
                        } else {
                            $td.addClass('sudoku-section-two');
                        }

                        $tr.append($td);
                    }

                    $table.append($tr);
                }

                return $table;
            },
            onKeyUp: function (event) {
                var sectRow,
                    sectCol,
                    secIndex,
                    isValid = true,
                    val = $.trim($(event.currentTarget).val()),
                    row = $(event.currentTarget).data('row'),
                    col = $(event.currentTarget).data('col');

                $('.sudoku-container').removeClass('valid-matrix');

                if (this._config.validate_on_insert) {
                    isValid = this.validateNumber(val, row, col, this._matrix.row[row][col]);
                    $(event.currentTarget).toggleClass('sudoku-input-error', !isValid);
                }

                sectRow = Math.floor(row / 3);
                sectCol = Math.floor(col / 3);
                secIndex = ( row % 3 ) * 3 + ( col % 3 );

                this._matrix.row[row][col] = val;
                this._matrix.col[col][row] = val;
                this._matrix.sect[sectRow][sectCol][secIndex] = val;
            },
            resetGame: function () {
                this.resetValidationMatrices();
                for (var row = 0; row < 9; row++) {
                    for (var col = 0; col < 9; col++) {
                        this._$cellMatrix[row][col].val('');
                    }
                }

                $('.sudoku-container input')
                    .removeAttr('disabled')
                    .removeClass('sudoku-input-error');
                $('.sudoku-container')
                    .removeClass('valid-matrix')
                    .removeClass('invalid-matrix');
            },
            resetValidationMatrices: function () {
                this._matrix = { 'row': {}, 'col': {}, 'sect': {} };
                this._validation = { 'row': {}, 'col': {}, 'sect': {} };

                for (var i = 0; i < 9; i++) {
                    this._matrix.row[i] = [ '', '', '', '', '', '', '', '', '' ];
                    this._matrix.col[i] = [ '', '', '', '', '', '', '', '', '' ];
                    this._validation.row[i] = [];
                    this._validation.col[i] = [];
                }

                for (var row = 0; row < 3; row++) {
                    this._matrix.sect[row] = [];
                    this._validation.sect[row] = {};
                    for (var col = 0; col < 3; col++) {
                        this._matrix.sect[row][col] = [ '', '', '', '', '', '', '', '', '' ];
                        this._validation.sect[row][col] = [];
                    }
                }
            },
            validateNumber: function (num, rowID, colID, oldNum) {
                var isValid = true,
                    sectRow = Math.floor(rowID / 3),
                    sectCol = Math.floor(colID / 3);

                oldNum = oldNum || '';

                if (this._validation.row[rowID].indexOf(oldNum) > -1) {
                    this._validation.row[rowID].splice(
                        this._validation.row[rowID].indexOf(oldNum), 1
                    );
                }
                if (this._validation.col[colID].indexOf(oldNum) > -1) {
                    this._validation.col[colID].splice(
                        this._validation.col[colID].indexOf(oldNum), 1
                    );
                }
                if (this._validation.sect[sectRow][sectCol].indexOf(oldNum) > -1) {
                    this._validation.sect[sectRow][sectCol].splice(
                        this._validation.sect[sectRow][sectCol].indexOf(oldNum), 1
                    );
                }

                if (num !== '') {

                    if ($.isNumeric(num) && Number(num) > 0 && Number(num) <= 9) {
                        isValid = !(
                            $.inArray(num, this._validation.row[rowID]) > -1 ||
                            $.inArray(num, this._validation.col[colID]) > -1 ||
                            $.inArray(num, this._validation.sect[sectRow][sectCol]) > -1
                            );
                    }

                    this._validation.row[rowID].push(num);
                    this._validation.col[colID].push(num);
                    this._validation.sect[sectRow][sectCol].push(num);
                }

                return isValid;
            },
            validateMatrix: function () {
                var isValid,
                    value,
                    hasError = false;

                for (var row = 0; row < 9; row++) {
                    for (var col = 0; col < 9; col++) {
                        value = this._matrix.row[row][col];
                        isValid = this.validateNumber(value, row, col, value);
                        this._$cellMatrix[row][col].toggleClass('sudoku-input-error', !isValid);
                        if (!isValid) {
                            hasError = true;
                        }
                    }
                }
                return !hasError;
            },
            solveGame: function (row, col) {
                var currentValue,
                    sqRow,
                    sqCol,
                    $nextSquare,
                    legalValues,
                    sectRow,
                    sectCol,
                    secIndex;

                $nextSquare = this.findClosestEmptySquare(row, col);
                if (!$nextSquare) {
                    return true;
                } else {
                    sqRow = $nextSquare.data('row');
                    sqCol = $nextSquare.data('col');
                    legalValues = this.findLegalValuesForSquare(sqRow, sqCol);

                    sectRow = Math.floor(sqRow / 3);
                    sectCol = Math.floor(sqCol / 3);
                    secIndex = ( sqRow % 3 ) * 3 + ( sqCol % 3 );

                    for (var i = 0; i < legalValues.length; i++) {
                        currentValue = legalValues[i];
                        $nextSquare.val(currentValue);
                        this._matrix.row[sqRow][sqCol] = currentValue;
                        this._matrix.col[sqCol][sqRow] = currentValue;
                        this._matrix.sect[sectRow][sectCol][secIndex] = currentValue;

                        if (this.solveGame(sqRow, sqCol)) {
                            return true;
                        } else {
                            this._$cellMatrix[sqRow][sqCol].val('');
                            this._matrix.row[sqRow][sqCol] = '';
                            this._matrix.col[sqCol][sqRow] = '';
                            this._matrix.sect[sectRow][sectCol][secIndex] = '';
                        }
                    }

                    return false;
                }
            },
            findClosestEmptySquare: function (row, col) {
                var walkingRow, walkingCol, found = false;
                for (var i = ( col + 9 * row ); i < 81; i++) {
                    walkingRow = Math.floor(i / 9);
                    walkingCol = i % 9;
                    if (this._matrix.row[walkingRow][walkingCol] === '') {
                        found = true;
                        return this._$cellMatrix[walkingRow][walkingCol];
                    }
                }
            },
            findLegalValuesForSquare: function (row, col) {
                var legalNumbers,
                    val,
                    i,
                    sectRow,
                    sectCol;

                legalNumbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9];

                for (i = 0; i < 9; i++) {
                    val = Number(this._matrix.col[col][i]);
                    if (val > 0) {
                        if (legalNumbers.indexOf(val) > -1) {
                            legalNumbers.splice(legalNumbers.indexOf(val), 1);
                        }
                    }
                }

                for (i = 0; i < 9; i++) {
                    val = Number(this._matrix.row[row][i]);
                    if (val > 0) {
                        if (legalNumbers.indexOf(val) > -1) {
                            legalNumbers.splice(legalNumbers.indexOf(val), 1);
                        }
                    }
                }

                sectRow = Math.floor(row / 3);
                sectCol = Math.floor(col / 3);
                for (i = 0; i < 9; i++) {
                    val = Number(this._matrix.sect[sectRow][sectCol][i]);
                    if (val > 0) {
                        if (legalNumbers.indexOf(val) > -1) {
                            legalNumbers.splice(legalNumbers.indexOf(val), 1);
                        }
                    }
                }

                if (this._config.solver_shuffle_numbers) {
                    for (i = legalNumbers.length - 1; i > 0; i--) {
                        var rand = getRandomInt(0, i);
                        var temp = legalNumbers[i];
                        legalNumbers[i] = legalNumbers[rand];
                        legalNumbers[rand] = temp;
                    }
                }

                return legalNumbers;
            }
        };

        function getRandomInt(min, max) {
            return Math.floor(Math.random() * ( max + 1 )) + min;
        }

        return {
            Game: Game
        };
    }());

    return Game;
});