var domModule = (function () {
    'use strict';

    var MAX_BUFFER_SIZE = 100,
        buffer = [];

    function appendChild(element, selector) {
        checkInputSelector(selector);
        var parentElement;

        parentElement = document.querySelector(selector);
        parentElement.appendChild(element);
    }

    function removeChild(element, selector) {
        checkInputSelector.call(null, element, selector);
        var parentElement,
            removeElement;

        parentElement = document.querySelector(element);
        removeElement = parentElement.querySelector(selector);
        parentElement.removeChild(removeElement);
    }

    function addHandler(selector, event, listener) {
        checkInputSelector(selector);
        var allElements,
            i,
            len;

        allElements = document.querySelectorAll(selector);

        for (i = 0, len = allElements.length; i < len; i += 1) {
            allElements[i].addEventListener(event, listener);
        }
    }

    function appendToBuffer(selector, element) {
        checkInputSelector(selector);
        if (buffer[selector]) {
            buffer[selector].push(element);
            if (buffer[selector].length >= MAX_BUFFER_SIZE) {
                var parent,
                    container,
                    i,
                    len;

                parent = document.querySelector(selector);
                container = document.createDocumentFragment();
                for (i = 0, len = buffer[selector].length; i < len; i += 1) {
                    container.appendChild(buffer[selector][i]);
                }

                parent.appendChild(container);
                buffer[selector] = [];
            }
        } else {
            buffer[selector] = [];
            buffer[selector].push(element);
        }
    }

    function checkInputSelector(selector) {
        if (!document.querySelector(selector)) {
            throw 'The input selector "' + selector + '" is not valid.';
        }
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer
    };
})();