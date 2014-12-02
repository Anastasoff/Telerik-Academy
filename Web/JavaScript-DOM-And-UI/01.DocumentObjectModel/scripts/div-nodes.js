usingQuerySelectorAll();
console.log('\n');
usingGetElementsByTagName();

function usingQuerySelectorAll() {
    console.log('Create a function using querySelectorAll()');

    var selectedDivs = document.querySelectorAll('div > div');

    for (var i = 0, length = selectedDivs.length; i < length; i++) {
        console.log(selectedDivs[i]);
    }
}

function usingGetElementsByTagName() {
    console.log('Create a function using getElementsByTagName()');

    var allDivs = document.getElementsByTagName('div');

    for (var i = 0, length = allDivs.length; i < length; i++) {
        if (allDivs[i].parentNode.nodeName === 'DIV') {
            console.log(allDivs[i]);
        }
    }
}