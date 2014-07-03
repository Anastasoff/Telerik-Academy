var Animals = (function () {
    var Mammal = (function () {
        function Mammal(name) {
            this._name = name;
            this._offspring = [];
        }

        Mammal.prototype.haveABaby = function () {
            var newBaby = new this.constructor('Baby ' + this._name);
            this._offspring.push(newBaby);
            return newBaby;
        };

        Mammal.prototype.getOffspring = function () {
            return this._offspring;
        };

        Mammal.prototype.toString = function () {
            return '[Mammal "' + this._name + '"]';
        };

        return Mammal;
    }());

    var Cat = (function () {
        Cat.prototype = new Mammal();
        Cat.prototype.constructor = Cat;

        function Cat(name) {
            this._name = name;
        }

        Cat.prototype.toString = function () {
            return '[Cat "' + this._name + '"]';
        };

        return Cat;
    }());

    return{
        Mammal: Mammal,
        Cat: Cat
    }
}());
