(function () {
    var canvas = document.getElementById('canvas-container'),
        ctx = canvas.getContext('2d'),
        ball = {
            x: 50,
            y: 50,
            r: 20
        },
        isAnimOn = false,
        w = 800,
        h = 500,
        speed = 2,
        updateX = speed,
        updateY = speed;

    function drawBall() {
        ctx.fillStyle = 'red';
        ctx.beginPath();
        ctx.arc(ball.x, ball.y, ball.r, 0, 2 * Math.PI);
        ctx.fill();
    }

    function moveBall() {
        ctx.clearRect(0, 0, w, h);

        if (ball.x + ball.r >= w) {
            updateX = -speed;
        }
        if (ball.x + ball.r <= 2 * ball.r) {
            updateX = speed;
        }
        if (ball.y + ball.r > h) {
            updateY = -speed;
        }
        if (ball.y + ball.r <= 2 * ball.r) {
            updateY = speed;
        }
        ball.x += updateX;
        ball.y += updateY;

        drawBall();
        if (isAnimOn) {
            requestAnimationFrame(moveBall);
        }
    }

    function onStartBtnClick() {
        isAnimOn = true;
        requestAnimationFrame(moveBall);
    }

    function onStopBtnClick() {
        isAnimOn = false;
    }

    document.getElementById('start-btn').addEventListener('click', onStartBtnClick);
    document.getElementById('stop-btn').addEventListener('click', onStopBtnClick);
}());