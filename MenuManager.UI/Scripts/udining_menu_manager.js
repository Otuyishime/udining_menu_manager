$(document).ready(function () {
    $('#load-menu-btn').on('click', function () {
        var date = $('#edit-menu-with-date').val();
        var meal_type = $('.select-menu-meal').val();
        alert('Load Menu with date ' + date.toString() + " and meal type " + meal_type.toString());
    });

    $('#feature-line-add-btn').on('click', function () {
        $.ajax({
            url: this.href,
            method: 'POST',
            cache: false,
            success: function (html) {
                $(html).insertAfter($('.Feature_Line_Item:last').closest('.form-group'));
            }
        });
        return false;
    });

    $('#gluteen-line-add-btn').on('click', function () {
        $.ajax({
            url: this.href,
            method: 'POST',
            cache: false,
            success: function (html) {
                $(html).insertAfter($('.Gluteen_Free_Line_Item:last').closest('.form-group'));
            }
        });
        return false;
    });

    $('#chef-line-add-btn').on('click', function () {
        $.ajax({
            url: this.href,
            method: 'POST',
            cache: false,
            success: function (html) {
                $(html).insertAfter($('.Chef_Line_Item:last').closest('.form-group'));
            }
        });
        return false;
    });

    $('#save-menu-btn').on('click', function () {
    });

    $('#print-menu-btn').on('click', function () {
        alert('Print menu btn clicked!');
    });
});

//var item_num = $('.chef-line-item:last').data('item-num') + 1;
//alert(item_num);
//$(
//    "<br />" +
//    "<div class=\"form-group\"> " +
//        "<div class=\"input-group input-group-sm chef-line-item\"" + "data-item-num=\"" + item_num + "\"" + ">" +
//            "<span class=\"input-group-addon feature_line_title_addon\">Item</span>" +
//            "<input class=\"form-control\" name=\"Chef_Line[" + item_num + "].Food_name\" placeholder=\"enter item\" type=\"text\" value=\"\">" +
//            "<span class=\"input-group-addon\">" +
//                "<input type=\"checkbox\" aria-label=\"...\">" +
//            "</span>" +
//        "</div>" +
//    "</div>"
//).insertAfter($('.chef-line-item:last').closest('.form-group'));