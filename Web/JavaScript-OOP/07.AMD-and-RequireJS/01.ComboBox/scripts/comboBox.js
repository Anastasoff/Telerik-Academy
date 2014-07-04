define(['jquery'], function ($) {
    'use strict';
    return $.fn.comboBox = function (items) {
        var $self,
            $items,
            isCollapsed;

        $self = $(this);
        $items = $self.children();
        $items.first().show();

        isCollapsed = true;
        $self.on('click', items, function () {
            var $this = $(this);
            if (isCollapsed) {
                $items.show();
                isCollapsed = false;
            }
            else {
                $items.hide();
                $this.show();
                isCollapsed = true;
            }
        });

        return $self;
    };
});