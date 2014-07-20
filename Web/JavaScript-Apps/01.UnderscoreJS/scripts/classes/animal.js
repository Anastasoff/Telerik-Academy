define(function () {
    'use strict';
    var Animal;

    Animal = (function () {
        function Animal(name, species, legs) {
            this._name = name;
            this._species = species;
            this._legs = legs;
        }

        Animal.prototype = {
            getName: function () {
                return this._name;
            },
            getSpecies: function () {
                return this._species;
            },
            getLegs: function () {
                return this._legs;
            }
        };

        return Animal;
    }());

    return Animal;
});