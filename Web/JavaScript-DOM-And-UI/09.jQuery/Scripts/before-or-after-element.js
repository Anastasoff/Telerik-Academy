/// <reference path="_references.js" />
(function () {
    var $container = $('#container'),
            countBefore = 1,
            countAfter = 1;

    $('#btn-before').on('click', onBeforeBtnClick);
    $('#btn-after').on('click', onAfterBtnClick);

    function onBeforeBtnClick() {
        $container.prepend($('<div />').append($('<strong />').html('before #' + countBefore++)));
    }

    function onAfterBtnClick() {
        $container.append($('<div />').append($('<strong />').html('after #' + countAfter++)));
    }
}());