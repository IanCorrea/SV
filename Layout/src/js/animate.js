//////////////////// Variables \\\\\\\\\\\\\\\\\\\\
var button = $('.nav-buttons .over');
var arrowAnimateIn = 'slideInDown';
var arrowAnimateOut = 'slideOutUp';
var figcaptionAnimateIn = 'zoomInUp';
var figcaptionAnimateOut = 'zoomOutDown';
var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
/////////////////// End Variables \\\\\\\\\\\\\\\\\\\

button.hover(
    function() {

        var arrow = $(this).closest('article').find('.arrow');
        var figcaption = $(this).closest('article').find('figcaption');        

        if ($(arrow).hasClass(arrowAnimateOut)) { $(arrow).removeClass(arrowAnimateOut); }
        if ($(figcaption).hasClass(figcaptionAnimateOut)) { $(figcaption).removeClass(figcaptionAnimateOut); }
        //if ($(figcaption).hasClass('infinite pulse')) { $(figcaption).removeClass('infinite pulse'); console.log('Limpo PULSE'); }

        $(arrow).css('visibility', 'visible');
        $(figcaption).css('visibility', 'visible');

        $(arrow).animateCss(arrowAnimateIn);
        //$(figcaption).animateCss(figcaptionAnimateIn, false);

        $(figcaption).addClass('animated ' + figcaptionAnimateIn).one(animationEnd, function() {
            console.log('ENTROU');
            $(figcaption).removeClass('animated ' + figcaptionAnimateIn);
            //if ($(figcaption).hasClass('display-n')) { $(figcaption).removeClass('display-n'); }
            //if ($(arrow).hasClass('display-n')) { $(arrow).removeClass('display-n'); }
            $(figcaption).animateCss('infinite pulse');
            //article.animateCss('infinite pulse', false);
            //console.log(article);
        });
    },
    function() {

        var arrow = $(this).closest('article').find('.arrow');
        var figcaption = $(this).closest('article').find('figcaption');

        if ($(arrow).hasClass(arrowAnimateIn)) { $(arrow).removeClass(arrowAnimateIn); }
        if ($(figcaption).hasClass(figcaptionAnimateIn)) { $(figcaption).removeClass(figcaptionAnimateIn); }
        if ($(figcaption).hasClass('infinite pulse')) { $(figcaption).removeClass('infinite pulse'); }

        //$(arrow).animateCss(arrowAnimateOut, true);
        //$(figcaption).animateCss(figcaptionAnimateOut, true);
        
        $(arrow).css('visibility', 'hidden');
        $(figcaption).css('visibility', 'hidden');
        console.log('passou');
    }
);


$.fn.extend({
    animateCss: function(animationName) {
        var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
        //if (!out) {$(this).removeClass('display-n');}
        this.addClass('animated ' + animationName).one(animationEnd, function() {
            $(this).removeClass('animated ' + animationName);
            //if (out) { $(this).addClass('display-n'); }
        });
        return this;
    }
});