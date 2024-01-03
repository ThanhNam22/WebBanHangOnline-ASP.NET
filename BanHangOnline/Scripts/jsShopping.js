$(document).ready(function () {
    $('body').on('click', '.btnAddToCart', function (e) {
        e.preventDefault();
        var id = $(this).data('id');       
        var tQuantity = $('#quantity_value').text();
        var quantity = 1;
        if (tQuantity.length != '') {
            quantity = parseInt(tQuantity);
        }
        alert(id + " " + quantity);
    });
});