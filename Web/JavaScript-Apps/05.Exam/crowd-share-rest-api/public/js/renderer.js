define(['jquery', 'register'], function ($, reg) {

    var login = function (container) {
        var $container = $(container);
        $container.load('resources/login.html');
    };

    var register = function (container) {
        var $container = $(container);
        $container.load('resources/register.html');
        reg.init();
    };

    var posts = function (container, data) {
        var $container = $(container);
        $container.empty();

        var $div = $('<div />')
            .attr('id', 'posts');

        for (var item in data) {
            var currentItem = data[item];
            var $postItem = $('<div />').addClass('post-item').attr('data-info', currentItem['id']);
            $postItem.append($('<h4 />').html('title: ' + currentItem['title']));
            $postItem.append($('<p />').html('body: ' + currentItem['body']));
            $postItem.append($('<span />').html('date: ' + currentItem['postDate']));
            $postItem.append($('<br />'));
            $postItem.append($('<strong />').html('user: ' + currentItem['user']['username']));
            $postItem.append($('<br />'));
            $div.append($postItem);
        }

        $container.append($div);
    };

    return {
        login: login,
        register: register,
        posts: posts
    }
});