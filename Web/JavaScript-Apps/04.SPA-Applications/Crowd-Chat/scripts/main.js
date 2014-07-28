(function () {
    "use strict";

    require.config({
        paths: {
            'jquery': './libs/jquery/dist/jquery',
            'sammy': './libs/sammy/lib/sammy',
            'handlebars': './libs/handlebars/handlebars'
        },
        shim: {
            'handlebars': {
                exports: 'Handlebars'
            }
        }
    });

    require(['jquery', 'sammy', './chat'], function ($, Sammy, chat) {

        var app = Sammy('#container', function () {
            this.get('#/', function () {
                $('#container').html($('<h2 />').append('This is my home page'));
            });

            this.get('#/chat', function () {
                $('#container').html($('<h2 />').append('This is the chat!'));
                chat.initChat();
            });

            this.get('#/about', function () {
                $('#container').html($('<h2 />').append('Its all about me!'));
            });
        });

        $(function () {
            app.run('#/');
        });
    });
}());