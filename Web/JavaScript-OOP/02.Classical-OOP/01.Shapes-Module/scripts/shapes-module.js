var Shapes = (function () {
    'use strict';

    var Shape = (function () {
        function Shape(x, y) {
            this._x = x;
            this._y = y;
        }

        Shape.prototype.getShape = function getShape() {
            return {
                x: this._x,
                y: this._y
            };
        };

        Shape.prototype.toString = function shapeToString() {
            return 'x = ' + this._x + ', y = ' + this._y;
        };

        return Shape;
    }());

    var Rect = (function () {
        function Rect(x, y, width, height) {
            Shape.call(this, x, y);
            this._width = width;
            this._height = height;
        }

        Rect.prototype = new Shape();
        Rect.prototype.constructor = Rect;

        Rect.prototype.getShape = function getShape() {
            var parent = Shape.prototype.getShape.call(this);
            parent.width = this._width;
            parent.height = this._height;

            return parent;
        };

        Rect.prototype.toString = function rectToString() {
            var parent = Shape.prototype.toString.call(this);

            return parent + ', width = ' + this._width + ', height = ' + this._height;
        };

        return Rect;
    }());

    var Circle = (function () {
        function Circle(x, y, radius) {
            Shape.call(this, x, y);
            this._radius = radius;
        }

        Circle.prototype = new Shape();
        Circle.prototype.constructor = Circle;

        Circle.prototype.getShape = function getShape() {
            var parent = Shape.prototype.getShape.call(this);
            parent.radius = this._radius;

            return parent;
        };

        Circle.prototype.toString = function circleToString() {
            var parent = Shape.prototype.toString.call(this);

            return parent + ', radius = ' + this._radius;
        };

        return Circle;
    }());

    var Line = (function () {
        function Line(x, y, x2, y2) {
            Shape.call(this, x, y);
            this._x2 = x2;
            this._y2 = y2;
        }

        Line.prototype = new Shape();
        Line.prototype.constructor = Line;

        Line.prototype.getShape = function getShape() {
            var parent = Shape.prototype.getShape.call(this);
            parent.toX = this._x2;
            parent.toY = this._y2;

            return parent;
        };

        Line.prototype.toString = function lineToString() {
            var parent = Shape.prototype.toString.call(this);

            return parent + ', x2 = ' + this._x2 + ', y2 = ' + this._y2;
        };

        return Line;
    }());

    return {
        Rect: Rect,
        Circle: Circle,
        Line: Line
    };

}());