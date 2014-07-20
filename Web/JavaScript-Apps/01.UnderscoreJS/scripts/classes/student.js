define(['person'], function (Person) {
    'use strict';
    var Student;

    Student = (function () {
        function Student(firstName, lastName, age, marks) {
            Person.call(this, firstName, lastName, age);
            this._marks = marks;
        }

        Student.prototype = new Person();
        Student.prototype.constructor = Student;

        Student.prototype.getAllMarks = function () {
            return this._marks;
        };

        Student.prototype.getAverageScore = function () {
            var sum,
                i,
                len;

            sum = 0;
            for (i = 0, len = this.getAllMarks().length; i < len; i++) {
                sum += this.getAllMarks()[i];
            }

            return sum / len;
        };

        Student.prototype.toString = function () {
            var parent = Person.prototype.toString.call(this);

            return parent + ', average score: ' + this.getAverageScore();
        };

        return Student;
    }());

    return Student;
});