(function () {
    var container = document.getElementById('container'),
        numberOfDivs = 5,
        divs = [],
        centerX = 200,
        centerY = 200,
        radius = 150,
        angle = 0;

    for (var i = 0; i < numberOfDivs; i++) {
        var currDiv = document.createElement('div');
        container.appendChild(currDiv);
        divs[i] = currDiv;
    }

    moveDivs();

    function moveDivs() {
        angle++;
        if (angle == 360) {
            angle = 0;
        }

        for (var i = 0; i < divs.length; i++) {
            var addition = (360 / divs.length) * i;
            var left = centerX + Math.cos((2 * 3.14 / 180) * (angle + addition)) * radius;
            var right = centerY + Math.sin((2 * 3.14 / 180) * (angle + addition)) * radius;
            divs[i].style.left = left + 'px';
            divs[i].style.top = right + 'px';
        }

        setTimeout(function () {
            moveDivs();
        }, 100);
    }
}());