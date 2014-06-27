(function () {
    'use strict';
    var domModule = function () {

        function appendChild(element, selector) {
            var parentElement = document.querySelector(selector);
            parentElement.appendChild(element);
        }

        function removeChild(element, selector) {
            var parentElement = document.querySelector(element);
            var removeElement = parentElement.querySelector(selector);
            parentElement.removeChild(removeElement);
        }

        function addHandler() {

        }

        function appendToBuffer() {

        }

        return {
            appendChild: appendChild,
            removeChild: removeChild,
            addHandler: addHandler,
            appendToBuffer: appendToBuffer

        };
    }();

    var div = document.createElement("div");

    //appends div to #wrapper
    domModule.appendChild(div, "#wrapper");

    //removes li:first-child from ul
    domModule.removeChild("ul", "li:first-child");

    //add handler to each a element with class button
    domModule.addHandler("a.button", 'click', function () {
        alert("Clicked");
    });
    domModule.appendToBuffer("container", div.cloneNode(true));
    domModule.appendToBuffer("#main-navul", navItem);
}());