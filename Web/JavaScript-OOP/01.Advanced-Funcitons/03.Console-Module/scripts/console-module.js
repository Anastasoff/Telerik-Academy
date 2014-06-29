var specialConsole = (function () {
    'use strict';

    function writeLine(str) {
        var result = stringFormat(str, arguments);
        window.console.log(result);
    }

    function writeError(str) {
        var result = stringFormat(str, arguments);
        window.console.error(result);
    }

    function writeWarning(str) {
        var result = stringFormat(str, arguments);
        window.console.warn(result);
    }

    function stringFormat(str, selfArguments) {
        var result;

        result = str.replace(/\{(\d+)\}/g, function (match, arg) {
            return selfArguments[+arg + 1];
        });

        return result;
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
}());