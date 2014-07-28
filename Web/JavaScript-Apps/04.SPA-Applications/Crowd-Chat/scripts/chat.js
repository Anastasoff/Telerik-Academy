define(['jquery', 'handlebars'], function ($, Handlebars) {
    "use strict";

    var url = 'http://crowd-chat.herokuapp.com/posts';
    var $container = $('#container');

    var addPost = function (data) {
        var deferred = $.Deferred();

        $.ajax({
            url: url,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json',
            timeout: 5000,
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.resolve(error);
            }
        });

        return deferred.promise();
    };

    var getPosts = function () {
        var deferred = $.Deferred();

        $.ajax({
            url: url,
            type: 'GET',
            timeout: 5000,
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.resolve(error);
            }
        });

        return deferred.promise();
    };

    var initChat = function () {
        $container.load('./resources/posts.html');
        getPosts()
            .then(function (data) {
                console.log(data);
                showPosts('#container', '#posts-template', data)
            });
    };

    function showPosts(container, templateID, inputDate) {
        var templateHTML = $(templateID).html();
        var template = Handlebars.compile(templateHTML);
        $(container).append(template({
            posts: inputDate
        }));
    }

    return {
        initChat: initChat
    }
});