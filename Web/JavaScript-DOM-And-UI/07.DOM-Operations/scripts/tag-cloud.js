(function () {
    var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];
    var tagCloud = generateTagCloud(tags, 17, 42);
    var container = document.getElementById('container');
    container.appendChild(tagCloud);

    function generateTagCloud(tags, minFontSize, maxFontSize) {
        var wordsCount = countDifferentTags(tags);
        var divResult = document.createElement('div');

        var min = Number.MAX_VALUE;
        var max = 0;
        for (var word in wordsCount) {
            if (wordsCount[word] > max) {
                max = wordsCount[word];
            }
            if (wordsCount[word] < min) {
                min = wordsCount[word];
            }
        }

        for (var word in wordsCount) {
            var span = document.createElement('span');

            if (wordsCount[word] === min) {
                span.style.fontSize = minFontSize + 'px';
            } else if (wordsCount[word] === max) {
                span.style.fontSize = maxFontSize + 'px';
            } else {
                span.style.fontSize = minFontSize + ((maxFontSize - minFontSize) / ((max - wordsCount[word]) + 1)) + 'px';
            }

            span.innerHTML = word + ' ';
            divResult.appendChild(span);
        }

        return divResult;
    }

    function countDifferentTags(words) {
        var wordsCount = {};
        var word = {};
        for (var i in words) {
            word = words[i].toLowerCase();
            if (wordsCount[word]) {
                wordsCount[word]++;
            }
            else {
                wordsCount[word] = 1;
            }
        }

        return wordsCount;
    }
}());