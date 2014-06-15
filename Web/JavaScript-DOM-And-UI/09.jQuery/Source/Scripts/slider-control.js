/// <reference path="_references.js" />
(function () {
    var $slider = $('#slider');
    var slide = 'li';
    var isSlideShowOn = false;
    var TRANSITION_TIME = 500;
    var TIME_BETWEEN_SLIDES = 5000;
    var slideShow = $('#slide-show').on('click', autoSlideShow);
    $('#btn-next').on('click', onNextBtnClick);
    $('#btn-prev').on('click', onPrevBtnClick);

    slides().fadeOut();
    slides().first().addClass('active');
    slides().first().fadeIn(TRANSITION_TIME);

    function slides() {
        return $slider.find(slide);
    }

    function onNextBtnClick() {
        var directionNext = 1;
        changeSlide(directionNext);
    }

    function onPrevBtnClick() {
        var directionPrev = -1;
        changeSlide(directionPrev);
    }

    function changeSlide(direction) {
        direction = direction || 1;
        var $i = $slider.find(slide + '.active').index();

        slides().eq($i).removeClass('active');
        slides().eq($i).fadeOut(TRANSITION_TIME);

        if (slides().length == $i + 1) {
            $i = -1;
        }

        slides().eq($i + direction).fadeIn(TRANSITION_TIME);
        slides().eq($i + direction).addClass('active');
    }

    function autoSlideShow() {
        if (!isSlideShowOn) {
            isSlideShowOn = true;
            return setInterval(changeSlide, TRANSITION_TIME + TIME_BETWEEN_SLIDES);
        } else {
            isSlideShowOn = false;
            return;
        }
    }
}());