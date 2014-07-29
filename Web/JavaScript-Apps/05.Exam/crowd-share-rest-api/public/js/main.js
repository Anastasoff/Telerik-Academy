(function () {
    require.config({
        paths: {
            'jquery': '../components/jquery/dist/jquery',
            'q': '../components/q/q',
            'underscore': '../components/underscore/underscore',
            'sammy': '../components/sammy/lib/sammy',
            'crypto': '../components/crypto-js/cryptojs-sha1',
            'handlebars': '../components/handlebars/handlebars'
        },
        shim: {
            'crypto': {
                exports: 'CryptoJS'
            },
            'handlebars': {
                exports: 'Handlebars'
            }
        }
    });

    require(['jquery', 'sammy', 'crypto', 'httpRequester', 'register', 'renderer'],
        function ($, Sammy, CryptoJS, httpRequester, register, renderer) {
            var container = '#container';

            var app = Sammy(container, function () {
                this.get('#/', function () {
                    $(container).html($('<h2 />').append('Crowd Share – Web Client'));
                });

                this.get('#/posts', function () {
                    $(container).html($('<h2 />').append('This is the chat!'));

                    httpRequester.getJSON('http://jsapps.bgcoder.com/post')
                        .then(function (data) {
                            renderer.posts(container, data);
                        });
                });

                this.get('#/register', function () {
                    $(container).html($('<h2 />').append('Register me!'));
                    renderer.register(container);
                });

                this.get('#/login', function () {
                    $(container).html($('<h2 />').append('Log me in!'));
                    renderer.login(container);
                });

                this.get('#/about', function () {
                    $(container).html($('<h2 />').append('До сега не бях писал толкова омазан код'));
                    $(container).html($('<h2 />').append('Дай Бог тройка :)'));
                });
            });

            $(function () {
                app.run('#/');
            });
        });
}());