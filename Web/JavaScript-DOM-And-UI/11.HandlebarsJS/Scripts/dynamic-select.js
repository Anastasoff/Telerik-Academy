/// <references path="_references.js" />
(function () {
    var items = [{
        value: 0,
        text: ''
    },
    {
        value: 1,
        text: 'One'
    },
    {
        value: 2,
        text: 'Two'
    },
    {
        value: 3,
        text: 'Three'
    },
    {
        value: 4,
        text: 'Four'
    },
    {
        value: 5,
        text: 'Five'
    },
    {
        value: 6,
        text: 'Six'
    },
    {
        value: 7,
        text: 'Seven'
    },
    {
        value: 8,
        text: 'Eight'
    },
    {
        value: 9,
        text: 'Nine'
    }];

    var templateHTML = $('#select-template').html();
    var template = Handlebars.compile(templateHTML);
    $('#select-container').append(template({ items: items }));
}());