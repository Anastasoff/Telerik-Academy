define(function () {
    'use strict';
    var Course;

    Course = (function () {
        function sortStudents(students, count, sortBy) {
            students.sort(function (first, second) {
                return second[sortBy] - first[sortBy];
            });

            return students.slice(0, count);
        }

        function Course(name, formula) {
            this._name = name;
            this._formula = formula;
            this._students = [];
        }

        Course.prototype = {
            addStudent: function (student) {
                this._students.push(student);
                return this;
            },
            calculateResults: function () {
                for (var student in this._students) {
                    if (this._students.hasOwnProperty(student)) {
                        var currentStudent = this._students[student];
                        currentStudent.totalResult = this._formula(currentStudent);
                    }
                }
            },
            getTopStudentsByExam: function (count) {
                return sortStudents(this._students, count, 'exam');
            },
            getTopStudentsByTotalScore: function (count) {
                return sortStudents(this._students, count, 'totalResult');
            }
        };

        return Course;
    }());

    return Course;
});