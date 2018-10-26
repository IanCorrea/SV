var home = $('a.home');
var customer = $('a.customer');
var provider = $('a.provider');
var sales = $('a.sales');
var report = $('a.report');
var panel = $('section.panels #panel');
/////////////////// End Variables \\\\\\\\\\\\\\\\\\\

$(home).on('click', function() { $(window).scrollTo(panel); });
$(customer).on('click', function() { $(window).scrollTo(panel); });
$(provider).on('click', function() { $(window).scrollTo(panel); });
$(sales).on('click', function() { $(window).scrollTo(panel); });
$(report).on('click', function() { $(window).scrollTo(panel); });