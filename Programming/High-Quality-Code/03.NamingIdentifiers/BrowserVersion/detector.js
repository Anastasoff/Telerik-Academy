function onCheckBrowserBtnClick() {
    var currentBrowser = window.navigator.appCodeName;
    var isMozilla = currentBrowser === 'Mozilla';
    if (isMozilla) {
        printInBrowser('This is Mozilla');
    } else {
        printInBrowser('This is not Mozilla');
    }
}

function onDetectBrowserBtnClick() {
    var N = navigator.appName;
    var UA = navigator.userAgent;
    var browserVersion = UA.match(/(opera|chrome|safari|firefox|msie)\/?\s*(\.?\d+(\.\d+)*)/i);
    var temp = UA.match(/version\/([\.\d]+)/i);

    if (browserVersion && (temp !== null)) {
        browserVersion[2] = temp[1];
    }

    if (browserVersion) {
        browserVersion = [browserVersion[1], browserVersion[2]];
    } else {
        browserVersion = [N, navigator.appVersion, '-?'];
    }

    printInBrowser(browserVersion);
}

function printInBrowser(args) {
    var result = document.getElementById('content');
    var p = document.createElement('p');

    if (typeof (args) !== 'string') {
        p.innerHTML = args.join(' ');
    } else {
        p.innerHTML = args;
    }

    result.appendChild(p);
}