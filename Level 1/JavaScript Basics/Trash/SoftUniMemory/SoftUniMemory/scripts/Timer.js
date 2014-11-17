var timer = (function() {
    var basePeriod = 1000;
    var currentSpeed = 1;
    var timerElement;
    var timeoutRef;
    var minutes = 0;
    var seconds = 0;

    return {
        start : function(speed, id) {
            if (speed >= 0) {
                currentSpeed = speed;
            }
            if (id) {
                timerElement = document.getElementById(id);
            }
            timer.run();
        },

        run: function() {
            if (timeoutRef) clearInterval(timeoutRef);
            if (timerElement) {
                timerElement.innerHTML = minutes + ':' + seconds;
            }
            if(seconds >= 59){
                seconds = 0;
                minutes++;
            }
            if (currentSpeed) {
                timeoutRef = setTimeout(timer.run, basePeriod/currentSpeed);
            }
            ++seconds;
        },

        setSpeed: function(speed) {
            currentSpeed = +speed;
            timer.run();
        }
    }

}());
window.onload = function(){timer.start(1, 'timer');};