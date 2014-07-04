define(['jquery', 'handlebars'], function ($) {
    'use strict';
    return $.fn.template = function (container, data) {
        var $self,
            templateHTML,
            template,
            $container,
            i;

        $self = $(this);
        templateHTML = $self.html();
        template = Handlebars.compile(templateHTML);
        $container = $(container);
        for (i = 0; i < data.length; i++) {
            $container.append(template(data[i]));
        }

        return $self;
    };
});