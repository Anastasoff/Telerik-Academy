(function () {
    'use strict';

    var paper = Raphael('container', 400, 200);

    var telerikLogo = paper.path('M10 30 L30 10 L70 50 L50 70 L30 50 L70 10 L90 30');
    telerikLogo.attr({
        'stroke-width': 10,
        stroke: '#5be500'
    });

    var telerik = paper.text(100, 50, 'Telerik');
    telerik.attr({
        'font-weight': 'bold',
        'font-size': 70,
        'font-family': 'Calibri, Arial',
        'text-anchor': 'start'
    });

    var tradeMark = paper.text(306, 50, 'R');
    tradeMark.attr({
        'font-size': 14,
        'font-weight': 'bold',
        'font-family': 'Calibri, Arial',
        'text-anchor': 'start'
    });
    var circleTM = paper.circle(310, 50, 8);
    circleTM.attr({
        'stroke-width': 2
    });
    var subtext = paper.text(110, 90, 'Develop experiences');
    subtext.attr({
        'font-size': 25,
        'font-family': 'Calibri, Arial',
        'text-anchor': 'start'
    });
})();