$(function () {

    function serializeFormToObject(formName) {

        var serializedObject = {};

        var serialArray = $(formName).serializeArray();

        serialArray.forEach(function (index) {
            serializedObject[index.name] = index.value;
        });

        return serializedObject;
    };

    function removeChildren(idOrClass, type) {
        if (type === 1 && $('#' + idOrClass).children().length > 0) {
            $('#' + idOrClass).empty();
        } else if (type === 2 && $('.' + idOrClass).children().length > 0) {
            $('.' + idOrClass).empty();
        }
    }

    //Appended item will need to contain project id 
    $('#create-project-button').on('click', function () {
            var path = '/Home/AddProject';

            var data_array = {
                "strName": $('#NewProject_strName').val(),
                "strAim": $('#NewProject_Aim').val(),
                "dtmProjectedFinishedDate": $('#NewProject_dtmProjectedFinishedDate').val(),
                "strDetails": $('#NewProject_strDetails').val()
            };
        
            data_array = JSON.stringify(data_array);

            $.post(path, { "projectdata": data_array },
                function (data) {
                    $('#ongoing-projects-container').append(
                        "<div class=\"col-md-12 project-boxes toggle-box show-project-task \"><p>" + data.projectName + "</p></div>"
                    );
            });
        }
    );

    $('.toggle-box').on('click', function () {

        var boxToToggle = "#" + $(this).attr('id') + "-child";

        $(boxToToggle).slideToggle("fast");

    });

    $(document).on('click', '.project-details, .show-project-task', function () {
        var toInsert = "";
        
        removeChildren("selected-items-container", 1);

        if ($(this).hasClass('project-details')) {
            toInsert = "<p>Details</p>"
        } else if ($(this).hasClass('show-project-task')) {

            toInsert = "<p>Task</p>"

        }
        $('#selected-items-container').append(
            "<div class=\"col-md-12 project-boxes toggle-box\">" + toInsert + "</div>"
        );

        this.stopPropagation(); // Stop the link inside the clickable div from calling the err..clickable div. Weird.
    });

});