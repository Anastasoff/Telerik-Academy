function onGetValueBtnClick() {
    var inputStr = document.getElementById('inputText').value;

    var content = document.createElement('p');
    content.innerHTML = inputStr;

    var result = document.getElementById('result');
    result.appendChild(content);
}