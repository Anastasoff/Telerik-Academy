define(['jquery'], function ($) {
    var Game = (function () {
        function Game(config) {
            this.config = config;
            this.recursionCounter = 0;
            this.$cellMatrix = {};
            this.matrix = {};
            this.validation = {};
            this.resetValidationMatrices();

            return this;
        }

        Game.prototype = {
            buildGUI: function () {
                var $td,
                    $tr,
                    $table = $('<table>')
                        .addClass('sudoku-container');

                for (var i = 0; i < 9; i++) {
                    $tr = $('<tr>');
                    this.$cellMatrix[i] = {};

                    for (var j = 0; j < 9; j++) {
                        this.$cellMatrix[i][j] = $('<input>')
                            .attr('maxLength', 1)
                            .data('row', i)
                            .data('col', j)
                            .on('keyup', $.proxy(this.onKeyUp, this));

                        $td = $('<td>').append(this.$cellMatrix[i][j]);

                        var sectIDi = Math.floor(i / 3);
                        var sectIDj = Math.floor(j / 3);

                        if ((sectIDi + sectIDj) % 2 === 0) {
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

                if (this.config.validate_on_insert) {
                    isValid = this.validateNumber(val, row, col, this.matrix.row[row][col]);
                    $(event.currentTarget).toggleClass('sudoku-input-error', !isValid);
                }

                sectRow = Math.floor(row / 3);
                sectCol = Math.floor(col / 3);
                secIndex = (row % 3) * 3 + (col % 3);

                this.matrix.row[row][col] = val;
                this.matrix.col[col][row] = val;
                this.matrix.sect[sectRow][sectCol][secIndex] = val;
            },

            resetGame: function () {
                this.resetValidationMatrices();
                for (var row = 0; row < 9; row++) {
                    for (var col = 0; col < 9; col++) {
                        this.$cellMatrix[row][col].val('');
                    }
                }

                $('.sudoku-container input').removeAttr('disabled');
                $('.sudoku-container').removeClass('valid-matrix');
            },

            resetValidationMatrices: function () {
                this.matrix = { 'row': {}, 'col': {}, 'sect': {} };
                this.validation = { 'row': {}, 'col': {}, 'sect': {} };

                for (var i = 0; i < 9; i++) {
                    this.matrix.row[i] = ['', '', '', '', '', '', '', '', ''];
                    this.matrix.col[i] = ['', '', '', '', '', '', '', '', ''];
                    this.validation.row[i] = [];
                    this.validation.col[i] = [];
                }

                for (var row = 0; row < 3; row++) {
                    this.matrix.sect[row] = [];
                    this.validation.sect[row] = {};
                    for (var col = 0; col < 3; col++) {
                        this.matrix.sect[row][col] = ['', '', '', '', '', '', '', '', ''];
                        this.validation.sect[row][col] = [];
                    }
                }
            },

            validateNumber: function (num, rowID, colID, oldNum) {
                var isValid = true,
                    sectRow = Math.floor(rowID / 3),
                    sectCol = Math.floor(colID / 3);

                oldNum = oldNum || '';

                if (this.validation.row[rowID].indexOf(oldNum) > -1) {
                    this.validation.row[rowID].splice(
                        this.validation.row[rowID].indexOf(oldNum), 1
                        );
                }
                if (this.validation.col[colID].indexOf(oldNum) > -1) {
                    this.validation.col[colID].splice(
                        this.validation.col[colID].indexOf(oldNum), 1
                        );
                }
                if (this.validation.sect[sectRow][sectCol].indexOf(oldNum) > -1) {
                    this.validation.sect[sectRow][sectCol].splice(
                        this.validation.sect[sectRow][sectCol].indexOf(oldNum), 1
                        );
                }

                if (num !== '') {
                    if ($.isNumeric(num) && Number(num) > 0 && Number(num) <= 9) {
                        isValid = !(
                        $.inArray(num, this.validation.row[rowID]) > -1 ||
                        $.inArray(num, this.validation.col[colID]) > -1 ||
                        $.inArray(num, this.validation.sect[sectRow][sectCol]) > -1
                        );
                    }

                    this.validation.row[rowID].push(num);
                    this.validation.col[colID].push(num);
                    this.validation.sect[sectRow][sectCol].push(num);
                }

                return isValid;
            },

            validateMatrix: function () {
                var isValid,
                    value,
                    hasError = false;

                for (var row = 0; row < 9; row++) {
                    for (var col = 0; col < 9; col++) {
                        value = this.matrix.row[row][col];
                        isValid = this.validateNumber(value, row, col, value);
                        this.$cellMatrix[row][col].toggleClass('sudoku-input-error', !isValid);
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

                this.recursionCounter++;
                $nextSquare = this.findClosestEmptySquare(row, col);
                if (!$nextSquare) {
                    return true;
                } else {
                    sqRow = $nextSquare.data('row');
                    sqCol = $nextSquare.data('col');
                    legalValues = this.findLegalValuesForSquare(sqRow, sqCol);

                    sectRow = Math.floor(sqRow / 3);
                    sectCol = Math.floor(sqCol / 3);
                    secIndex = (sqRow % 3) * 3 + (sqCol % 3);

                    for (var i = 0; i < legalValues.length; i++) {
                        currentValue = legalValues[i];
                        $nextSquare.val(currentValue);
                        this.matrix.row[sqRow][sqCol] = currentValue;
                        this.matrix.col[sqCol][sqRow] = currentValue;
                        this.matrix.sect[sectRow][sectCol][secIndex] = currentValue;

                        if (this.solveGame(sqRow, sqCol)) {
                            return true;
                        } else {
                            this.backtrackCounter++;
                            this.$cellMatrix[sqRow][sqCol].val('');
                            this.matrix.row[sqRow][sqCol] = '';
                            this.matrix.col[sqCol][sqRow] = '';
                            this.matrix.sect[sectRow][sectCol][secIndex] = '';
                        }
                    }

                    return false;
                }
            },

            findClosestEmptySquare: function (row, col) {
                var walkingRow, walkingCol, found = false;
                for (var i = (col + 9 * row); i < 81; i++) {
                    walkingRow = Math.floor(i / 9);
                    walkingCol = i % 9;
                    if (this.matrix.row[walkingRow][walkingCol] === '') {
                        found = true;
                        return this.$cellMatrix[walkingRow][walkingCol];
                    }
                }
            },

            findLegalValuesForSquare: function (row, col) {
                var legalNumbers,
                    val,
                    i,
                    sectRow,
                    sectCol;

                legalNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

                for (i = 0; i < 9; i++) {
                    val = Number(this.matrix.col[col][i]);
                    if (val > 0) {
                        if (legalNumbers.indexOf(val) > -1) {
                            legalNumbers.splice(legalNumbers.indexOf(val), 1);
                        }
                    }
                }

                for (i = 0; i < 9; i++) {
                    val = Number(this.matrix.row[row][i]);
                    if (val > 0) {
                        if (legalNumbers.indexOf(val) > -1) {
                            legalNumbers.splice(legalNumbers.indexOf(val), 1);
                        }
                    }
                }

                sectRow = Math.floor(row / 3);
                sectCol = Math.floor(col / 3);
                for (i = 0; i < 9; i++) {
                    val = Number(this.matrix.sect[sectRow][sectCol][i]);
                    if (val > 0) {
                        if (legalNumbers.indexOf(val) > -1) {
                            legalNumbers.splice(legalNumbers.indexOf(val), 1);
                        }
                    }
                }

                if (this.config.solver_shuffle_numbers) {
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
            return Math.floor(Math.random() * (max + 1)) + min;
        }

        return {
            Game: Game
        };
    } ());

    return Game;
});