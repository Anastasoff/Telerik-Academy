(function() {
    function onBodyLoaded() {
        var button = document.getElementById('btn-create-divs');
        button.style.backgroundColor = '#000';
    }

    function randomGenerator() {
        return (Math.random() * 100) | 0;
    }

    function getRandomColor() {
        var letters = '0123456789ABCDEF'.split('');
        var color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[(Math.random() * 16) | 0];
        }
        return color;
    }
}());