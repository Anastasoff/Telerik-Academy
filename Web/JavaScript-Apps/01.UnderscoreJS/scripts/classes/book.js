define(function () {
    'use strict';
    var Book;

    Book = (function () {
        function Book(name, author) {
            this._name = name;
            this._author = author;
        }

        Book.prototype = {
            getName: function () {
                return this._name;
            },
            getAuthor: function () {
                return this._author;
            }
        };

        return Book;
    }());

    return Book;
});