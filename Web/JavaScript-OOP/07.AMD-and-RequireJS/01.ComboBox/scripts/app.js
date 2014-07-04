(function () {
    'use strict';
    require.config({
        paths: {
            'jquery': 'libs/bower_components/jquery/dist/jquery',
            'handlebars': 'libs/bower_components/handlebars/handlebars'
        }
    });

    require(['jquery', 'data', 'template', 'comboBox'], function ($, people) {
        $('#template-container').template('#comboBox-container', people);
        $('#comboBox-container').comboBox('.person-item');
    });
}());