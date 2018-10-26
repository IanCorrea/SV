$(document).ready(function () {
    $('.cpf').mask('000.000.000-00', { reverse: true });   
    $('.money').mask("0000000000000000,00", { reverse: true });
    $('.age').mask("000");
    validatePhone();

});


function validatePhone() {

    var masks = ['(00) 00000-0000', '(00) 0000-00009'],
        maskBehavior = function (val, e, field, options) {
            return val.length > 14 ? masks[0] : masks[1];
        };

    $('.phone').mask(maskBehavior, {
        onKeyPress:
                    function (val, e, field, options) {
                        field.mask(maskBehavior(val, e, field, options), options);
                    }
    });
}