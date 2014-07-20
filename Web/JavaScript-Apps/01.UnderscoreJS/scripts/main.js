define(['./tasks', './data'], function (tasks, data) {
    'use strict';

    console.log('All students');
    console.log(data.students);
    console.log('----------');

    // -------------------   1.   -------------------
    // Write a method that from a given array of students
    // finds all students whose first name is before its last name alphabetically.
    // Print the students in descending order by full name.
    console.log('Task 1');
    console.log(tasks.findStudentsByName(data.students));
    console.log('----------');

    // -------------------   2.   -------------------
    // Write function that finds the first name and last name of
    // all students with age between 18 and 24.
    console.log('Task 2');
    // May need to be refreshed couple of times to get a proper result, because the age is generated randomly
    console.log(tasks.findStudentsByAge(data.students).length > 0 ? tasks.findStudentsByAge(data.students) : 'There are no students between 18 and 24 years.');
    console.log('----------');

    // -------------------   3.   -------------------
    // Write a function that by a given array of students finds the student with highest marks
    console.log('Task 3');
    console.log(tasks.findStudentsByMarks(data.students).toString());
    console.log('----------');

    // -------------------   4.   -------------------
    // Write a function that by a given array of animals, groups them by species and sorts them by number of legs
    console.log('Task 4');
    console.log(tasks.groupAnimalsBySpecies(data.animals));
    console.log('----------');

    // -------------------   5.   -------------------
    // By a given array of animals, find the total number of legs
    console.log('Task 5');
    console.log(tasks.findTotalNumberOfLegs(data.animals));
    console.log('----------');

    // -------------------   6.   -------------------
    // By a given collection of books, find the most popular author
    // (the author with the highest number of books)
    console.log('Task 6');
    console.log(tasks.findMostPopularAuthor(data.books));
    console.log('----------');

    // -------------------   7.   -------------------
    // By an array of people find the most common first and last name.
    console.log('Task 7');
    console.log(tasks.findMostCommonNames(data.people).firstName); // TODO: bug
    console.log(tasks.findMostCommonNames(data.people).lastName);
    console.log('----------');
});