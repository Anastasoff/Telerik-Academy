define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;

    Store = (function () {

        function inputValidation(name) {
            var MIN_NAME_LENGTH = 6;
            var MAX_NAME_LENGTH = 40;

            if (MIN_NAME_LENGTH > name.length && name.length < MAX_NAME_LENGTH) {
                throw  new Error('Invalid length of the Item name');
            }
        }

        function sortItemsBy(items, sortBy) {
            var itemsToSort = items.slice(0);
            return itemsToSort.sort(function (first, second) {
                if (first[sortBy] < second[sortBy]) return -1;
                if (first[sortBy] > second[sortBy]) return 1;
                return 0;
            });
        }

        function Store(name) {
            inputValidation(name);
            this._name = name;
            this._items = [];
        }

        Store.prototype = {
            addItem: function (item) {
                if (!(item instanceof Item)) {
                    throw new Error('Invalid input in addItem()');
                }

                this._items.push(item);
                return this;
            },
            getAll: function () {
                return sortItemsBy(this._items, '_name');
            },
            getSmartPhones: function () {
                var sortedItems = sortItemsBy(this._items, '_name');
                var smartPhones = [];

                for (var smartPhone in sortedItems) {
                    if (sortedItems[smartPhone].getType() === 'smart-phone') {
                        smartPhones.push(sortedItems[smartPhone]);
                    }
                }

                return smartPhones;
            },
            getMobiles: function () {
                var sortedItems = sortItemsBy(this._items, '_name');
                var mobiles = [];

                for (var mobile in sortedItems) {
                    if (sortedItems[mobile].getType() === 'smart-phone' || sortedItems[mobile].getType() === 'tablet') {
                        mobiles.push(sortedItems[mobile]);
                    }
                }

                return mobiles;
            },
            getComputers: function () {
                var sortedItems = sortItemsBy(this._items, '_name');
                var computers = [];

                for (var computer in sortedItems) {
                    if (sortedItems[computer].getType() === 'pc' || sortedItems[computer].getType() === 'notebook') {
                        computers.push(sortedItems[computer]);
                    }
                }

                return computers;
            },
            filterItemsByPrice: function (options) {
                var result = [];
                var min = 0;
                var max = Number.MAX_VALUE;
                if (options !== undefined) {
                    if (options.min) {
                        min = options.min;
                    }

                    if (options.max) {
                        max = options.max;
                    }
                }

                for (var i = 0; i < this._items.length; i++) {
                    var currentItem = this._items[i];
                    if (min < currentItem.getPrice() && currentItem.getPrice() < max) {
                        result.push(currentItem);
                    }
                }

                return sortItemsBy(result, '_price');
            },
            filterItemsByType: function (filterType) {
                var sortedItems = sortItemsBy(this._items);
                var filteredItems = [];

                for (var sm in sortedItems) {
                    if (sortedItems[sm].getType() === filterType) {
                        filteredItems.push(sortedItems[sm]);
                    }
                }

                return filteredItems;
            },
            filterItemsByName: function (partOfName) {
                var sortedItems = sortItemsBy(this._items);
                var filteredItems = [];

                for (var item in sortedItems) {
                    var currentItem = sortedItems[item];
                    if (currentItem.getName().toLowerCase().indexOf(partOfName) >= 0) {
                        filteredItems.push(currentItem);
                    }
                }

                return filteredItems;
            },
            countItemsByType: function () {
                var result = {};

                for (var i = 0, len = this._items.length; i < len; i++) {
                    var current = this._items[i];
                    if (!result[current.getType()]) {
                        result[current.getType()] = 1;
                    } else {
                        result[current.getType()] += 1;
                    }
                }

                return result;
            }
        };

        return Store;
    }());
    return Store;
});