$(document).ready(function(){
	$('ul.tabs li a:first').addClass('active');
	$('.secciones article').hide();
	$('.secciones article:first').show();

    $('ul.tabs li a').click(function () {
        $('ul.tabs li').removeClass('active');
		$('ul.tabs li a').removeClass('active');
		$(this).addClass('active');
		$('.secciones article').hide();

		var activeTab = $(this).attr('href');
		$(activeTab).show();
		return false;
    });

    $('#pasarTab1-Tab2').click(function () {
        $('ul.tabs li').removeClass('active');
        $('ul.tabs li a').removeClass('active');
        $('ul.tabs li').first().next().addClass('active');
        $('.secciones article').hide();

        var activeTab = $(this).attr('href');
        $(activeTab).show();
        return false;
    });

    $('#pasarTab2-Tab3').click(function () {
        $('ul.tabs li').removeClass('active');
        $('ul.tabs li a').removeClass('active');
        $('ul.tabs li').first().next().next().addClass('active');
        $('.secciones article').hide();

        var activeTab = $(this).attr('href');
        $(activeTab).show();
        return false;
    });


    $('#pasarTab3-Tab4').click(function () {
        $('ul.tabs li').removeClass('active');
        $('ul.tabs li a').removeClass('active');
        $('ul.tabs li').first().next().next().next().addClass('active');
        $('.secciones article').hide();

        var activeTab = $(this).attr('href');
        $(activeTab).show();
        return false;
    });



});


function toggle(source) {
    checkboxes = document.getElementsByClassName('misCheckBox');
    for (var i = 0; i < checkboxes.length; ++i) {
        checkboxes[i].checked = source.checked;
    }
}