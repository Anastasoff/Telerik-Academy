define(['httpRequester'], function (httpRequester) {
    var url = 'http://jsapps.bgcoder.com/user';

    function toAuthCode(username, password) {
        return {
            username: username,
            authCode: CryptoJS.SHA1(username + password).toString()
        };
    }

    function getUser() {
        var $username = $('tb-username').val();
        var $password = $('tb-password').val();
        var user = {
            username: $username,
            authCode: toAuthCode($username, $password)
        };

        httpRequester.postJSON(url, user)
            .then(function (data) {
                console.log(data);
            });
    }

    var init = function () {
        $('#tb-login').on('click', getUser);
    };

    return {
        init: init
    }
});