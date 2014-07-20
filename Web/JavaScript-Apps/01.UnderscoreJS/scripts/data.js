define(['chance', 'student', 'animal', 'book', 'person'], function (Chance, Student, Animal, Book, Person) {
    'use strict';

    var chance,
        students,
        animals,
        books,
        people;

    chance = new Chance();

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
            currentStudent = new Student(chance.first(), chance.last(), chance.age('adult'), marks());
            randomStudents.push(currentStudent);
        }

        return randomStudents;
    }());

    // Array of animals
    animals = [
        new Animal('Wolf', 'Mammal', 4),
        new Animal('Gorilla', 'Mammal', 2),
        new Animal('Spider', 'Insect', 8),
        new Animal('Bear', 'Mammal', 4),
        new Animal('Shark', 'Fish', 0),
        new Animal('Mosquito', 'Insect', 6),
        new Animal('Skumriq', 'Fish', 0),
        new Animal('Crocodile', 'Reptile', 4),
        new Animal('Eagle', 'Bird', 2),
        new Animal('Human', 'Mammal', 2),
        new Animal('Caterpillar', 'Insect', 100)

    ];

    // Array of books
    books = [
        new Book("The Da Vinci Code", "Dan Brown"),
        new Book("Harry Potter and the Order of the Phoenix ", "J. K. Rowling"),
        new Book("Harry Potter and the Goblet of Fire", "J. K. Rowling"),
        new Book("Harry Potter and the Deathly Hallows", "J. K. Rowling"),
        new Book("The Hobbit, or There and Back Again", "J. R. R. Tolkien"),
        new Book("Harry Potter and the Sorcerer's Stone", "J. K. Rowling"),
        new Book("Harry Potter and the Half-Blood Prince", "J. K. Rowling"),
        new Book("Harry Potter and the Chamber of Secrets", "J. K. Rowling"),
        new Book("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling"),
        new Book("Nineteen Eighty-Four", "George Orwell")
    ];

    // Array of people
    people = [
        new Person('Ivan', 'Ivanov', 18),
        new Person('Pesho', 'Peshev', 22),
        new Person('Pesho', 'Ivanov', 34),
        new Person('Gosho', 'Georgiev', 66),
        new Person('Gosho', 'Peshev', 45),
        new Person('Pesho', 'Peshev', 100),
    ];

    return {
        students: students,
        animals: animals,
        books: books,
        people: people
    };

});