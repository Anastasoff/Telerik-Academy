define(['jquery'], function ($) {
    var getJSON = function (url) {
        var deferred = $.Deferred();

        $.ajax({
            url: url,
            type: 'GET',
            timeout: 5000,
            contentType: 'application/json',
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.resolve(error);
            }
        });

        return deferred.promise();
    };

    var postJSON = function (url, data) {
        var deferred = $.Deferred();

        $.ajax({
            url: url,
            type: 'POST',
            data: JSON.stringify(data),
            timeout: 5000,
            contentType: 'application/json',
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.resolve(error);
            }
        });

        return deferred.promise();
    };

    return {
        getJSON: getJSON,
        postJSON: postJSON
    };
});