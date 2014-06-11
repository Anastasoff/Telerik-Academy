(function () {
    'use strict';

    var paper = Raphael('container', 300, 100);

    var you = paper.text(10, 40, 'You');
    you.attr({
        'font-size': 70,
        "font-family": "Calibri",
        'font-weight': 'bold',
        "text-anchor": "start"
    });

    var redRect = paper.rect(120, 0, 160, 85, 20);
    redRect.attr({
        fill: 'red',
        stroke: 'red'
    });

    var tube = paper.text(130, 40, 'Tube');
    tube.attr({
        'font-size': 70,
        "font-family": "Calibri",
        'font-weight': 'bold',
        "text-anchor": "start",
        fill: 'white'
    });
}());