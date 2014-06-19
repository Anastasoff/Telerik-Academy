/// <reference path="../Scripts/_references.js" />
(function ($) {
    'use strict';
    $.fn.gallery = function (colums) {
        colums = colums || 4;

        var $this = $(this);
        $this.addClass('gallery');
        $this.css('width', colums * 260);

        function removeAllSelected() {
            var $selected = $this.find('.selected');
            $selected.children().remove();
        }

        removeAllSelected();

        function addToSelected($currentSelected) {
            var $selected = $this.find('.selected');

            var $prev = $currentSelected.prev();
            var $next = $currentSelected.next();

            $selected.append($currentSelected.clone(true).removeClass('image-container').addClass('current-image'));
            $selected.append($prev.clone(true).removeClass('image-container').addClass('previous-image'));
            $selected.append($next.clone(true).removeClass('image-container').addClass('next-image'));
        }

        $this.on('click', '.image-container', function () {
            var $clicked = $(this);
            addToSelected($clicked);
            $clicked.addClass('current-view');

            $this.find('.gallery-list').children().addClass('blurred');
        });

        $this.on('click', '.previous-image', function () {
        });

        $this.on('click', '.current-image', function () {
            $this.find('.image-container').removeClass('blurred');
            $this.find('.image-container').removeClass('current-view');
            removeAllSelected();
        });

        $this.on('click', '.next-image', function () {
        });
    };
}(jQuery));