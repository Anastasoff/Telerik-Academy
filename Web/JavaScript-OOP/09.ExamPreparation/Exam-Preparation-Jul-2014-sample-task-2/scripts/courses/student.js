define(function () {
    'use strict';
    var Student;

    Student = (function () {
        function Student(studentObject) {
            for (var property in studentObject) {
                if (studentObject.hasOwnProperty(property)) {
                    this[property] = studentObject[property];
                }
            }
        }

        return Student;
    }());

    return Student;
});