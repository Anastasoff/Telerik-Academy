window.onload = function () {
    function drawBall(ball) {
        var x = ball.x,
            y = ball.y;
        ctx.fillStyle = 'red';
        ctx.beginPath();
        ctx.arc(x, y, 20, 0, 2 * Math.PI);
        ctx.fill();
    }

    function frame() {
        drawBall(ball);
        ball.x += 2;
        ball.y += 2;
        window.requestAnimationFrame(frame);
    }

    var canvas = document.getElementById('canvas-container');
    var ctx = canvas.getContext('2d');
    var ball = {
        x: 100,
        y: 100
    };
    var down = true,
        up = false,
        left = false,
        right = true;
    frame();
}