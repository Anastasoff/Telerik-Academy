/// <reference path="_references.js" />
(function ($) {
    $.fn.dropdown = function () {
        var $this = $(this);
        $this.hide();
        var options = [];
        var $options = $this.children();

        for (var i = 0; i < $options.length; i++) {
            options.push({
                option: $options[i].innerHTML,
                value: $options[i].value
            });
        }

        var $container = $('<div>').addClass('dropdown-list-container');
        var $ul = $('<ul>').addClass('dropdown-list-options');
        var $selectionContainer = $('<li>')
                .addClass('dropdown-list-selectionContainer')
                .text('Choose option')
                .attr('data-value', 'not-selected')
                .appendTo($ul);

        for (var j = 0; j < options.length; j++) {
            var currOption = $('<li>')
                    .text(options[j].option)
                    .attr('data-value', options[j].value)
                    .on('click', function () {
                        var $target = $(this);
                        $('.dropdown-list-options li[selected]').removeAttr('selected');
                        $target.attr('selected', 'selected');
                        $selectionContainer.text($target.text());
                        $selectionContainer.attr('data-value', $target.attr('data-value'));
                        $('.dropdown-list-options li:not(.dropdown-list-selectionContainer)').slideUp('fast');
                    })
                    .appendTo($ul);
        }
        $allOptions = $selectionContainer.siblings().hide();

        $selectionContainer.on('click', function () {
            $allOptions.slideToggle();
        })
        $ul.appendTo($container);
        $container.appendTo($this.parent());
    };
}(jQuery));