var Drawer = (function () {
    'use strict';

    var canvas,
        ctx;

    function Drawer(selector) {
        this._selector = selector;
        canvas = document.getElementById(this._selector);
        ctx = canvas.getContext('2d');
    }

    Drawer.prototype.drawShape = function (shape) {
        if (shape instanceof shapes.Rect) {
            drawRect(shape.getShape());
        } else if (shape instanceof shapes.Circle) {
            drawCircle(shape.getShape());
        } else if (shape instanceof shapes.Line) {
            drawLine(shape.getShape());
        }
    };

    var drawRect = function (rect) {
        ctx.beginPath();
        ctx.rect(rect.x, rect.y, rect.width, rect.height);
        ctx.stroke();
    };

    var drawCircle = function (circle) {
        ctx.beginPath();
        ctx.arc(circle.x, circle.y, circle.radius, 0, 2 * Math.PI);
        ctx.stroke();
    };

    var drawLine = function (line) {
        ctx.beginPath();
        ctx.moveTo(line.x, line.y);
        ctx.lineTo(line.toX, line.toY);
        ctx.stroke();
    };

    return Drawer;
}());