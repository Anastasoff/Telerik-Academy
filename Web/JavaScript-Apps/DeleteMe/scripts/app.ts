class Person {
    _firstName:string;
    _lastName:string;

    constructor(firstName, lastName) {
        this._firstName = firstName;
        this._lastName = lastName;
    }
}


var p1:Person = new Person("Pesho", "Peshev");

var p2:Person = new Person("Gosho", "Goshov");

var people = [];
people.push(p1);
people.push(p2);

var result = _.chain(people)
    .sortBy("_firstName")
    .value();

console.log(people);

console.log(result);