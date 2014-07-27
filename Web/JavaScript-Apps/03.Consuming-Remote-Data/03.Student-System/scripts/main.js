(function () {
    'use strict';
    require.config({
        paths: {
            'jquery': './libs/jquery/dist/jquery',
            'Q': './libs/q/q',
            'handlebars': './libs/handlebars/handlebars'
        },
        shim: {
            'handlebars': {
                exports: 'Handlebars'
            }
        }
    });

    require(['jquery', 'handlebars', './student-system'], function ($, Handlebars, studentSystem) {
        $("#students-container").load("students.html");

        $('#btn-add-student').on('click', function () {
            var student = {
                name: $('#tb-name').val(),
                grade: $('#tb-grade').val()
            };

            studentSystem.add(student)
                .then(function (data) {
                    console.log(data);
                }, function (error) {
                    console.log(error);
                });
        });

        $('#btn-getAll-students').on('click', function () {
            studentSystem.getAll()
                .then(function (data) {
                    createTable('#students-container', '#students-template', data.students);
                });

        });

        $('#btn-remove-student').on('click', function () {
            var id = $('#tb-id').val();
            studentSystem.remove(id)
                .then(function (data) {
                    console.log(data);
                }, function (error) {
                    console.log(error);
                });
        });

        function createTable(container, templateID, inputDate) {
            var templateHTML = $(templateID).html();
            var template = Handlebars.compile(templateHTML);
            $(container).append(template({
                rows: inputDate
            }));
        }

    });
}());