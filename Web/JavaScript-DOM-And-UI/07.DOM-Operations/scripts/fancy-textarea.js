(function () {
    var fontColor = document.getElementById('font-color'),
        backgroundColor = document.getElementById('background-color'),
        textArea = document.getElementById('text-area');

    fontColor.addEventListener('change', function () {
        textArea.style.color = fontColor.value;
    })

    backgroundColor.addEventListener('change', function () {
        textArea.style.backgroundColor = backgroundColor.value;
    })
}());