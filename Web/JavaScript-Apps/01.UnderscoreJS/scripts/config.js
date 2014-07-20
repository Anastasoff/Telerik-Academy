(function () {
    require.config({
        paths: {
            'underscore': 'libs/underscore',
            'chance': 'libs/chance',
            'person': './classes/person',
            'student': './classes/student',
            'animal': './classes/animal',
            'book': './classes/book'
        }
    });

    require(['main']);
}());