$(function () {

    //$('.project-boxes').click(function () {

    //    var testMe = $(this).attr('id');

    //    $('.project-boxes[id=' + testMe + ']').animate({ top: 5 }, 1000);

    //    $('.project-boxes[id!=' + testMe + ']').animate({ left: -100, opacity: 0 }, 700,
	//	function () {
	//	    $(this).remove();
	//	});

    //});

    $('#create-project-button').click(
        function () {
            data_array = $("#create-project-form").serialize();
            
        }
    );

    $('#add-project-box').click(function () {

        var boxAttribute = '#testMeNow';

        $(boxAttribute).slideToggle("fast");

    });

});