var movingShapes = (function () {
    'use strict';

    var divs = [],
        container = document.getElementById('container'),
        div = document.createElement('div'),
        ellipseCenterX = 175,
        ellipseCenterY = 125,
        ellipseX = 125,
        ellipseY = 50;

    div.style.width = '50px';
    div.style.height = '50px';
    div.style.position = 'absolute';
    div.innerHTML = 'just div';

    function add(movement) {
        var clone = div.cloneNode(true);

        if (movement === 'rect') {
            clone.style.top = '50px';
            clone.style.left = '50px';
            clone.setAttribute('data-direction', 'right');
        } else {
            clone.setAttribute('data-angle', 0);
        }

        clone.className = movement;
        clone.style.backgroundColor = getRandomRgbColor();
        clone.style.border = '5px solid ' + getRandomRgbColor();
        clone.style.color = getRandomRgbColor();
        clone.style.fontWeight = 'bold';

        container.appendChild(clone);

        divs.push(clone);
    }

    function engine() {
        for (var i = 0; i < divs.length; i += 1) {
            if (divs[i].className === 'rect') {
                rectMovement(divs[i]);
            } else {
                ellipseMovement(divs[i]);
            }
        }
    }

    function rectMovement(element) {
        if (element.style.left === '300px' && element.style.top === '50px') {
            element.setAttribute('data-direction', 'down');
        }

        if (element.style.left === '300px' && element.style.top === '200px') {
            element.setAttribute('data-direction', 'left');
        }

        if (element.style.left === '50px' && element.style.top === '200px') {
            element.setAttribute('data-direction', 'up');
        }

        if (element.style.left === '50px' && element.style.top === '50px') {
            element.setAttribute('data-direction', 'right');
        }

        var currentTop = parseInt(element.style.top, 10),
            currentLeft = parseInt(element.style.left, 10);

        switch (element.getAttribute('data-direction')) {
            case 'right':
                currentLeft += 1;
                break;
            case 'down':
                currentTop += 1;
                break;
            case 'left':
                currentLeft -= 1;
                break;
            case 'up':
                currentTop -= 1;
                break;
        }

        element.style.top = currentTop + 'px';
        element.style.left = currentLeft + 'px';
    }

    function ellipseMovement(element) {
        var angle = parseFloat(element.getAttribute('data-angle')),
            newAngle = angle + 0.05;

        element.setAttribute('data-angle', newAngle);

        element.style.left = ellipseCenterX + (ellipseX * Math.cos(newAngle)) + 'px';
        element.style.top = ellipseCenterY + (ellipseY * Math.sin(newAngle)) + 'px';
    }

    function getRandomRgbColor() {
        var red = getRandomInt(0, 255),
            green = getRandomInt(0, 255),
            blue = getRandomInt(0, 255);

        return 'rgb(' + red + ',' + green + ',' + blue + ')';
    }

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    setInterval(engine, 20);

    return {
        add: add
    };
}());



