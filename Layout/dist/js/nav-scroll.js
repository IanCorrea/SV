//////////////////// Variables \\\\\\\\\\\\\\\\\\\\
var navscroll = $('figure.images-ms .background');
var nav = $('#nav-default');
var animateIn = 'zoomInLeft';
var browser_width;
/////////////////// End Variables \\\\\\\\\\\\\\\\\\\

window.ondragstart = function() { return false; };

$(document).ready(function() {
    $(window).scrollTop(0); //set scroll to top

    if (window.outerWidth < screen.width) { browser_width = window.outerWidth; } else { browser_width = screen.width; }
    console.log(browser_width);
    if (browser_width >= 975) {
        action_navscroll(true);
    } else {
        action_navscroll(false);
        $(navscroll).show().addClass('animated ' + animateIn);
    }
});

$(window).resize(function() {
    console.log('resize');
    window.location = window.location;
    window.location.reload();

});

action_navscroll = (function(scroll) {

    $(navscroll).hide().removeClass('animated ' + animateIn);

    //////////////////// Change the Code Behind the Bootstrap \\\\\\\\\\\\\\\\\\\\
    $(window).off('.affix'); //
    $(nav).removeData('bs.affix').removeClass('affix affix-top affix-bottom');
    $(nav).affix({ offset: 160 });
    ////////////////// End Change the Code Behind the Bootstrap \\\\\\\\\\\\\\\\\\\  

    $(window).scroll(function() {
        if (scroll) {
            //var wScroll = document.documentElement.scrollTop;
            var wScroll = window.pageYOffset;
            console.log(wScroll);
            if (wScroll >= 160) {
                $(nav).affix({ offset: { top: 160 } });
                $(navscroll).show().addClass('animated ' + animateIn);
            } else {
                $(nav).affix({ offset: { top: 0 } });
                $(navscroll).hide();
            }
        }
    });
});