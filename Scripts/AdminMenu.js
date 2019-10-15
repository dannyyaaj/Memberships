$(function () {
    //target li element with attribute of data-admin-menu
    $('[data-admin-menu]').hover(function () {
        console.log($(this), 'THIS');
        $(this).toggleClass('open');
    });
});