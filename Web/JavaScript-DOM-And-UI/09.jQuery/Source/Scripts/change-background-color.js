/// <reference path="_references.js" />
(function () {
    var $wrapper = $('#wrapper');
    var $colorPicker = $('<input />');
    $colorPicker.attr('type', 'color');
    $colorPicker.attr('id', 'color-picker');
    $wrapper.append($colorPicker);

    $('#color-picker').on('change', function () {
        var $pickedColor = $(this).val();
        $('body').css('background-color', $pickedColor);
    });
}());