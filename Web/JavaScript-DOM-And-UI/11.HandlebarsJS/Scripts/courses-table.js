/// <references path="_references.js" />
(function () {
    var tableData = {
        header: {
            fields: [{
                name: 'Title'
            }, {
                name: 'Date#1'
            }, {
                name: 'Date#2'
            }]
        },

        rows: [{
            fields: [{
                content: 'Course introduction'
            }, {
                content: 'Wed 18:00, 28-May-2014'
            }, {
                content: 'Thu 14:00, 29-May-2014'
            }]
        }, {
            fields: [{
                content: 'Document Object Model'
            }, {
                content: 'Wed 18:00, 28-May-2014'
            }, {
                content: 'Thu 14:00, 29-May-2014'
            }]
        }, {
            fields: [{
                content: 'HTML5 Canvas'
            }, {
                content: 'Thu 18:00, 29-May-2014'
            }, {
                content: 'Fri 14:00, 30-May-2014'
            }]
        }, {
            fields: [{
                content: 'Kinetic JS Overview'
            }, {
                content: 'Thu 18:00, 29-May-2014'
            }, {
                content: 'Fri 14:00, 30-May-2014'
            }]
        }, {
            fields: [{
                content: 'SVG and RaphaelJS'
            }, {
                content: 'Wed 18:00, 04-Jun-2014'
            }, {
                content: 'Thu 14:00, 05-Jun-2014'
            }]
        }, {
            fields: [{
                content: 'Animations with Canvas and SVG'
            }, {
                content: 'Wed 18:00, 04-Jun-2014'
            }, {
                content: 'Thu 14:00, 05-Jun-2014'
            }]
        }, {
            fields: [{
                content: 'DOM operations'
            }, {
                content: 'Thu 18:00, 05-Jun-2014'
            }, {
                content: 'Fri 14:00, 06-Jun-2014'
            }]
        }, {
            fields: [{
                content: 'Event model'
            }, {
                content: 'Thu 18:00, 05-Jun-2014'
            }, {
                content: 'Fri 14:00, 06-Jun-2014'
            }]
        }, {
            fields: [{
                content: 'jQuery overview'
            }, {
                content: 'Wed 18:00, 11-Jun-2014'
            }, {
                content: 'Thu 14:00, 12-Jun-2014'
            }]
        }, {
            fields: [{
                content: 'Exam preparation'
            }, {
                content: 'Thu 18:00, 12-Jun-2014'
            }, {
                content: 'Fri 14:00, 13-Jun-2014'
            }]
        }, {
            fields: [{
                content: 'Teamwork Defense'
            }, {
                content: '16-20 Jun 2014'
            }, {
                content: '16-20 Jun 2014'
            }]
        }, {
            fields: [{
                content: 'Exam'
            }, {
                content: '16-20 Jun 2014'
            }, {
                content: '16-20 Jun 2014'
            }]
        }
        ]
    };

    function createTable(container, templateID, inputDate) {
        var templateHTML = $(templateID).html();
        var template = Handlebars.compile(templateHTML);
        $(container).append(template(inputDate));
    }

    createTable('#table-container', '#table-template', tableData);
}());