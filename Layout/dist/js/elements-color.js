//////////////////// Variables \\\\\\\\\\\\\\\\\\\\
var home = $('a.home');
var customer = $('a.customer');
var provider = $('a.provider');
var sales = $('a.sales');
var report = $('a.report');
var panel = $('section.panels #panel');
var panelHeading = $('section.panels #panel .panel-heading');
var buttonName;
/////////////////// End Variables \\\\\\\\\\\\\\\\\\\

$(home).on('click', function() { panelType(home, 'Home'); });
$(customer).on('click', function() { panelType(customer, 'Clientes'); });
$(provider).on('click', function() { panelType(provider, 'Colaboradores'); });
$(sales).on('click', function() { panelType(sales, 'Vendas'); });
$(report).on('click', function() { panelType(report, 'Relatório de Vendas'); });

panelType = (function(button, name_ptbr) {    
    buttonName = $(button).attr('class');

    panel.removeClass();
    panel.addClass('panel panel-' + buttonName);

    panelHeading.children('h3').text(name_ptbr);
});