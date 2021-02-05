$(function () {
    $.datetimepicker.setDateFormatter('moment');
    $(".datetimefield").datetimepicker({
        format: 'DD/MM/YYYY hh:mm A',
        formatTime: 'h:mm A'
    });
});