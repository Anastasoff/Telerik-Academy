define(['./factory'], function (factory) {
    'use strict';

    var chance,
        students,
        animals,
        books,
        people;

    chance = factory.getChanceJS();

    // Generate random marks
    function marks() {
        var randomMarks = [],
            NUMBER_OF_MARKS = 10,
            i;

        for (i = 0; i < NUMBER_OF_MARKS; i++) {
            randomMarks.push(chance.integer({min: 2, max: 6}));
        }

        return randomMarks;
    }

    //Generate random students
    students = (function () {
        var randomStudents = [],
            STUDENTS_COUNT = 20,
            i,
            currentStudent;

        for (i = 0; i < STUDENTS_COUNT; i++) {
            currentStudent = factory.getStudent(chance.first(), chance.last(), chance.age('adult'), marks());
            randomStudents.push(currentStudent);
        }

        return randomStudents;
    }());

    // Array of animals
    animals = [
        factory.getAnimal('Wolf', 'Mammal', 4),
        factory.getAnimal('Gorilla', 'Mammal', 2),
        factory.getAnimal('Spider', 'Insect', 8),
        factory.getAnimal('Bear', 'Mammal', 4),
        factory.getAnimal('Shark', 'Fish', 0),
        factory.getAnimal('Mosquito', 'Insect', 6),
        factory.getAnimal('Skumriq', 'Fish', 0),
        factory.getAnimal('Crocodile', 'Reptile', 4),
        factory.getAnimal('Eagle', 'Bird', 2),
        factory.getAnimal('Human', 'Mammal', 2),
        factory.getAnimal('Caterpillar', 'Insect', 100)

    ];

    // Array of books
    books = [
        factory.getBook("The Da Vinci Code", "Dan Brown"),
        factory.getBook("Harry Potter and the Order of the Phoenix ", "J. K. Rowling"),
        factory.getBook("Harry Potter and the Goblet of Fire", "J. K. Rowling"),
        factory.getBook("Harry Potter and the Deathly Hallows", "J. K. Rowling"),
        factory.getBook("The Hobbit, or There and Back Again", "J. R. R. Tolkien"),
        factory.getBook("Harry Potter and the Sorcerer's Stone", "J. K. Rowling"),
        factory.getBook("Harry Potter and the Half-Blood Prince", "J. K. Rowling"),
        factory.getBook("Harry Potter and the Chamber of Secrets", "J. K. Rowling"),
        factory.getBook("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling"),
        factory.getBook("Nineteen Eighty-Four", "George Orwell")
    ];

    // Array of people
    people = [
        factory.getPerson('Ivan', 'Ivanov', 18),
        factory.getPerson('Pesho', 'Peshev', 22),
        factory.getPerson('Pesho', 'Ivanov', 34),
        factory.getPerson('Gosho', 'Georgiev', 66),
        factory.getPerson('Gosho', 'Peshev', 45),
        factory.getPerson('Pesho', 'Peshev', 100)
    ];

    return {
        students: students,
        animals: animals,
        books: books,
        people: people
    };
});