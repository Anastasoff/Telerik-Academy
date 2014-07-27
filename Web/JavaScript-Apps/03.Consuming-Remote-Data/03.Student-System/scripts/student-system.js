define(['jquery', 'Q'], function ($, Q) {
    'use strict';
    var resourceUrl = 'http://localhost:3000/students',
        addStudent,
        getAllStudents,
        removeStudent;

    addStudent = function (student) {
        var deferred = Q.defer();

        $.ajax({
            type: 'POST',
            url: resourceUrl,
            data: JSON.stringify(student),
            contentType: 'application/json',
            timeout: 5000,
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (data) {
                deferred.resolve(data);
            }
        });

        return deferred.promise;
    };

    getAllStudents = function () {
        var deferred = Q.defer();

        $.ajax({
            type: 'GET',
            url: resourceUrl,
            timeout: 5000,
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (data) {
                deferred.resolve(data);
            }

        });

        return deferred.promise;
    };

    removeStudent = function (id) {
        var deferred = Q.defer();

        $.ajax({
            type: 'POST',
            url: resourceUrl + '/' + id,
            data: {
                _method: 'delete'
            },
            timeout: 5000,
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (data) {
                deferred.resolve(data);
            }
        });

        return deferred.promise;
    };

    return {
        add: addStudent,
        getAll: getAllStudents,
        remove: removeStudent
    }
});