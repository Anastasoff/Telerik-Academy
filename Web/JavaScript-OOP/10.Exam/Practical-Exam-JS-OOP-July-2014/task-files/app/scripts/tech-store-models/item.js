define(function () {
    'use strict';
    var Item;

    Item = (function () {
        function inputValidation(type, name, price) {
            var MIN_NAME_LENGTH = 6;
            var MAX_NAME_LENGTH = 40;
            var validTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];
            if (validTypes.indexOf(type) < 0) {
                throw new Error('Invalid input Item type');
            }

            if (MIN_NAME_LENGTH > name.length && name.length < MAX_NAME_LENGTH) {
                throw  new Error('Invalid length of the Item name');
            }

            if (!(typeof price === 'number')) {
                throw  new Error('Invalid input price');
            }
        }

        function Item(type, name, price) {
            inputValidation(type, name, price);

            this._type = type;
            this._name = name;
            this._price = price;
        }

        Item.prototype = {
            getType: function () {
                return this._type;
            },
            getName: function () {
                return this._name;
            },
            getPrice: function () {
                return this._price;
            }
        };

        return Item;
    }());
    return Item;
});