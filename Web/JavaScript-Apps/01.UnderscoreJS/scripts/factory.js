define(['chance', 'student', 'animal', 'book', 'person'], function (Chance, Student, Animal, Book, Person) {
    'use strict';

    function getChanceJS() {
        return new Chance();
    }

    function getPerson(firstName, lastName, age) {
        return new Person(firstName, lastName, age);
    }

    function getStudent(firstName, lastName, age, marks) {
        return new Student(firstName, lastName, age, marks);
    }

    function getAnimal(name, species, legs) {
        return new Animal(name, species, legs);
    }

    function getBook(name, author) {
        return new Book(name, author);
    }

    return{
        getChanceJS: getChanceJS,
        getPerson: getPerson,
        getStudent: getStudent,
        getAnimal: getAnimal,
        getBook: getBook
    }
});