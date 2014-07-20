define(function () {
    'use strict';
    var Person;

    Person = (function () {
        function Person(firstName, lastName, age) {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }

        Person.prototype = {
            getFirstName: function () {
                return this._firstName;
            },
            getLastName: function () {
                return this._lastName;
            },
            getFullName: function () {
                return this._firstName + ' ' + this._lastName;
            },
            getAge: function () {
                return this._age;
            },
            toString: function () {
                return this.getFullName() + ', age: ' + this.getAge();
            }
        };

        return Person;
    }());

    return Person;
});