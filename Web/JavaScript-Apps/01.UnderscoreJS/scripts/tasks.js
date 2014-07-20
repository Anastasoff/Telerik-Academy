define(['underscore'], function (_) {
    'use strict';
    var findStudentsByName = function (students) {
        return _.chain(students)
            .filter(function (student) {
                return student.getFirstName() < student.getLastName();
            })
            .sortBy(function (student) {
                return student.getFullName();
            })
            .reverse()
            .value();
    };

    var findStudentsByAge = function (students) {
        var MIN_RANGE = 18,
            MAX_RANGE = 24;

        return _.chain(students)
            .filter(function (student) {
                return MIN_RANGE >= student.getAge() && student.getAge() <= MAX_RANGE;
            })
            .value();
    };

    var findStudentsByMarks = function (students) {
        return _.chain(students)
            .max(function (student) {
                return student.getAverageScore();
            })
            .value();
    };

    var groupAnimalsBySpecies = function (animals) {
        return _.chain(animals)
            .groupBy(function (animal) {
                return animal.getSpecies();
            })
            .map(function (group) {
                return _.sortBy(group, function (animal) {
                    return animal.getLegs();
                })
            })
            .value();
    };

    var findTotalNumberOfLegs = function (animals) {
        var totalLegsCount = 0;

        _.each(animals, function (animal) {
            totalLegsCount += animal.getLegs();
        });

        return totalLegsCount;
    };

    var findMostPopularAuthor = function (books) {
        return _.chain(books)
            .groupBy(function (book) {
                return book.getAuthor();
            })
            .max(function (group) {
                return group.length;
            })
            .first()
            .value()
            .getAuthor();
    };

    var findMostCommonNames = function (people) {
        function findMostCommonProperty(items, prop) {
            return _.chain(items)
                .groupBy(function (item) {
                    return item[prop];
                })
                .max(function (group) {
                    return group.length;
                })
                .first()
                .value()[prop];
        }

        var firstName = findMostCommonProperty(people, '_firstName'); // TODO: cannot find a way to use the getter 'getFirstName()'

        var lastName = findMostCommonProperty(people, '_lastName'); // TODO: cannot find a way to use the getter 'getLastName()'

        return {
            firstName: firstName,
            lastName: lastName
        };
    };

    return {
        findStudentsByName: findStudentsByName,
        findStudentsByAge: findStudentsByAge,
        findStudentsByMarks: findStudentsByMarks,
        groupAnimalsBySpecies: groupAnimalsBySpecies,
        findTotalNumberOfLegs: findTotalNumberOfLegs,
        findMostPopularAuthor: findMostPopularAuthor,
        findMostCommonNames: findMostCommonNames
    };

});