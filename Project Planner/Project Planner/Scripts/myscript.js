$(function () {

    $('.project-boxes').click(function () {

        var testMe = $(this).attr('id');

        $('.project-boxes[id=' + testMe + ']').animate({ top: 5 }, 1000);

        $('.project-boxes[id!=' + testMe + ']').animate({ left: -100, opacity: 0 }, 700,
		function () {
		    $(this).remove();
		});

    });

});