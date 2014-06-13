'use strict';

var inputValue = document.getElementById('input-btn');
inputValue.addEventListener('click', generateRandomDivs);

var clearDivs = document.getElementById('clear-btn');
clearDivs.addEventListener('click', function () {
    var divs = document.getElementById('container');
    while (divs.firstChild) {
        divs.removeChild(divs.firstChild);
    }
});

function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getRandomDiv(min, max) {
    var newDiv = document.createElement('div');
    newDiv.style.width = getRandomInt(min, max) + 'px';
    newDiv.style.height = getRandomInt(min, max) + 'px';
    newDiv.style.backgroundColor = getRandomColor();
    newDiv.style.color = getRandomColor();
    newDiv.style.position = 'absolute';
    newDiv.style.top = getRandomInt(50, 500) + 'px';
    newDiv.style.left = getRandomInt(50, 1000) + 'px';
    newDiv.style.borderWidth = getRandomInt(1, 20) + 'px';
    newDiv.style.borderStyle = 'solid';
    newDiv.style.borderColor = getRandomColor();
    newDiv.style.borderRadius = getRandomInt(0, 20) + 'px';

    return newDiv;
}

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[getRandomInt(0, 15)];
    }
    return color;
}

function generateRandomDivs() {
    var divCount,
        container,
        divFragments;

    divCount = document.getElementById('input').value | 0;

    container = document.getElementById('container');
    divFragments = document.createDocumentFragment();

    for (var i = 0; i < divCount; i++) {
        var item = getRandomDiv(20, 100);
        var strong = document.createElement('strong');
        strong.innerHTML = 'div #' + (i + 1);
        item.appendChild(strong);

        divFragments.appendChild(item);
    }

    container.appendChild(divFragments);
}