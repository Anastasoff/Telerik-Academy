/// <reference path="Scripts/_references.js" />

(function ($) {
    $.fn.tabs = function () {
        var $this = $(this);
        $this.addClass('tabs-container');
        hideTabControlContent();

        $this.on('click', '.tab-item-title', function () {
            var $tabControl = $(this);
            hideTabControlContent();
            $this.find('.tab-item').removeClass('current');
            var $next = $tabControl.next().show();
            $next.parent().addClass('current');
        });

        function hideTabControlContent() {
            $this.find('.tab-item-content').hide();
        }
    };
}(jQuery));