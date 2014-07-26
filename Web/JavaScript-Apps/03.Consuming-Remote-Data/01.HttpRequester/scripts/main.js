(function () {
    'use strict';
    require.config({
        paths: {
            'jquery': 'libs/jquery/dist/jquery'
        }
    });

    require(['jquery', 'http-request-module'], function ($, httpRequest) {
        var url = "http://localhost:3000/students",
            headers = {
                contentType: 'application/json',
                accept: 'application/json'
            };

        $('#btn-add-student').on('click', function () {
            var student;
            student = {
                name: $('#tb-name').val(),
                grade: $('#tb-grade').val()
            };

            console.log(student);
            httpRequest.postJSON(url, student, headers);
        });

        $('#btn-get-students').on('click', function () {
            httpRequest.getJSON(url, headers)
                .then(function (data) {
                    console.log(JSON.parse(data));
                }, function (error) {
                    console.log(error);
                });
        });
    });
}());