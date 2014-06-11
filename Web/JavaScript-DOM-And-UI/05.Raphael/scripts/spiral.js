// Thanks to http://the55.net/resources/implements55#spiral
(function () {
    'use strict';

    var paper = Raphael("container", 600, 600);

    var arcString = function (startX, startY, endX, endY, radius1, radius2, angle, largeArcFlag) {
        largeArcFlag = largeArcFlag || 0;
        var arcSVG = [radius1, radius2, angle, largeArcFlag, 1, endX, endY].join(' ');
        return startX + ' ' + startY + " a " + arcSVG;
    }

    var drawSpiral = function (centerX, centerY, spacing, maxRadius) {
        var pathAttributes = ['M', centerX, centerY];
        var angle = 0;
        var startX = centerX;
        var startY = centerY;

        for (var radius = 0; radius < maxRadius; radius++) {
            angle += spacing;
            var endX = centerX + radius * Math.cos(angle * Math.PI / 180);
            var endY = centerY + radius * Math.sin(angle * Math.PI / 180);

            pathAttributes.push(arcString(startX, startY, endX - startX, endY - startY, radius, radius, 0));
            startX = endX; startY = endY;
        }
        return pathAttributes.join(' ');
    }

    paper.path(drawSpiral(300, 300, 50, 250));
}());