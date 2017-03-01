$(document).ready(function () {
    $('#load-menu-btn').on('click', function () {
        var date = $('#edit-menu-with-date').val();
        var meal_type = $('.select-menu-meal').val();
        alert('Load Menu with date ' + date.toString() + " and meal type " + meal_type.toString());
    });

    $('#feature-line-add-btn').on('click', function () {
        $(
            "<br />"+
            "<div class=\"input-group input-group-sm feature-line-item\">"+
                "<span class=\"input-group-addon feature_line_title_addon\">Item</span>" +
                "<input type=\"text\" class=\"form-control\" placeholder=\"enter item\">" +
                "<span class=\"input-group-addon\">" +
                    "<input type=\"checkbox\" aria-label=\"...\">" +
                "</span>" +
            "</div>"
        ).insertAfter('.feature-line-item:last').last();
    });

    $('#gluteen-line-add-btn').on('click', function () {
        $(
            "<br />" +
            "<div class=\"input-group input-group-sm gluteen-line-item\">" +
                "<span class=\"input-group-addon feature_line_title_addon\">Item</span>" +
                "<input type=\"text\" class=\"form-control\" placeholder=\"enter item\">" +
                "<span class=\"input-group-addon\">" +
                    "<input type=\"checkbox\" aria-label=\"...\">" +
                "</span>" +
            "</div>"
        ).insertAfter('.gluteen-line-item:last').last();
    });

    $('#chef-line-add-btn').on('click', function () {
        $(
            "<br />" +
            "<div class=\"input-group input-group-sm chef-line-item\">" +
                "<span class=\"input-group-addon feature_line_title_addon\">Item</span>" +
                "<input type=\"text\" class=\"form-control\" placeholder=\"enter item\">" +
                "<span class=\"input-group-addon\">" +
                    "<input type=\"checkbox\" aria-label=\"...\">" +
                "</span>" +
            "</div>"
        ).insertAfter('.chef-line-item:last');
    });
});