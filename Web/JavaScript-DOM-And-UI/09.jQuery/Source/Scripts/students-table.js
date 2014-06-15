/// <reference path="_references.js" />
(function () {
    var students = [
        { firstName: "Pesho", lastName: "Peshev", grade: 8 },
        { firstName: "Gosho", lastName: "Goshev", grade: 11 },
        { firstName: "Atanas", lastName: "Atanasov", grade: 5 },
        { firstName: "Ivan", lastName: "Ivanov", grade: 8 },
        { firstName: "Gosho", lastName: "Nikolov", grade: 12 },
        { firstName: "Vasil", lastName: "Peshev", grade: 10 }
    ];

    var $wrapper = $('#wrapper');
    var $table = $('<table />');
    var $tableHeader = $('<tr />');

    $tableHeader.append($('<th />').html('First Name'));
    $tableHeader.append($('<th />').html('Last Name'));
    $tableHeader.append($('<th />').html('Grade'));
    $tableHeader.appendTo($table);

    for (var st in students) {
        var $current = $('<tr />');
        $current.append($('<td />').text(students[st].firstName));
        $current.append($('<td />').text(students[st].lastName));
        $current.append($('<td />').text(students[st].grade));
        $current.appendTo($table);
    }

    $wrapper.append($table);
}());