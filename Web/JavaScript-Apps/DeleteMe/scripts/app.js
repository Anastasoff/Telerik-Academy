var Person = (function () {
    function Person(firstName, lastName) {
        this._firstName = firstName;
        this._lastName = lastName;
    }
    return Person;
})();

var p1 = new Person("Pesho", "Peshev");

var p2 = new Person("Gosho", "Goshov");

var people = [];
people.push(p1);
people.push(p2);

var result = _.chain(people).sortBy("_firstName").value();

console.log(people);

console.log(result);
//# sourceMappingURL=app.js.map
