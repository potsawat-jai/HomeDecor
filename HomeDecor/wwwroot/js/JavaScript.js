$(document).ready(function () {

    $('.Getproductdetails').on('click', function () {
        console.log($(this));
        $('#m-productImg').attr("src", $(this).find('#productImg').attr("src"));
        $('#m-productname').text($(this).find('#product-name').text());
        $('#m-productdetail').text($(this).find('#product-detail').text());
        $('#m-category').text($(this).find('#category').text());
        let price = $(this).find('#Mainprice').text().replaceAll(' ', '').replace(/\n/g, "");
        let discountprice = $(this).find('#Discountprice').text().replaceAll(' ', '').replace(/\n/g, "");
        let amount = $(this).find('#product-amount').text();
        let unit = $(this).find('#product-unit').text();


        if (parseInt(amount) >= 1) {
            $('#m-amount').text('In stock').css('color', 'green');
            $("#amount-product").val(1).attr({
                "max": parseInt(amount),        // substitute your own
                "min": 1         // values (or variables) here
            });
            $('.btn-number').attr("disabled", false);
            $('#amount-product').attr("disabled", false);
            $('#add-product').attr("disabled", false);
        } else {
            $('#m-amount').text('Out of stock').css('color', 'red');
            $("#amount-product").val(0).attr({
                "max": 0,        // substitute your own
                "min": 0          // values (or variables) here
            });
            $('.btn-number').attr("disabled", true);
            $('#amount-product').attr("disabled", true);
            $('#add-product').attr("disabled", true);
        }

        if (parseInt(unit) >= 1) {
            $('#m-stockunit').text($(this).find('#product-unit').text());
        } else {
            $('#m-stockunit').text('N/A');
        }
        if ($(this).find('#Discountprice').length <= 0) {
            $('#m-mainprice').text(price)
                .removeClass('text-secondary text-decor-line-through')
                .addClass('text-danger');
            $('#m-discountprice').text('');
        } else {
            $('#m-mainprice').text(price).addClass('text-secondary text-decor-line-through').removeClass('text-danger');
            $('#m-discountprice').text(discountprice);
        }

    });


    $('.btn-number').click(function (e) {
        e.preventDefault();

        fieldName = $(this).attr('data-field');
        type = $(this).attr('data-type');
        var input = $("input[name='" + fieldName + "']");
        var currentVal = parseInt(input.val());
        if (!isNaN(currentVal)) {
            if (type == 'minus') {

                if (currentVal > input.attr('min')) {
                    input.val(currentVal - 1).change();
                }
                if (parseInt(input.val()) == input.attr('min')) {
                    $(this).attr('disabled', true);
                }

            } else if (type == 'plus') {

                if (currentVal < input.attr('max')) {
                    input.val(currentVal + 1).change();
                }
                if (parseInt(input.val()) == input.attr('max')) {
                    $(this).attr('disabled', true);
                }

            }
        } else {
            input.val(0);
        }
    });
    $('.input-number').focusin(function () {
        $(this).data('oldValue', $(this).val());
    });
    $('.input-number').change(function () {

        minValue = parseInt($(this).attr('min'));
        maxValue = parseInt($(this).attr('max'));
        valueCurrent = parseInt($(this).val());

        name = $(this).attr('name');
        if (valueCurrent >= minValue) {
            $(".btn-number[data-type='minus'][data-field='" + name + "']").removeAttr('disabled')
        } else {
            alert('Sorry, the minimum value was reached');
            $(this).val($(this).data('oldValue'));
        }
        if (valueCurrent <= maxValue) {
            $(".btn-number[data-type='plus'][data-field='" + name + "']").removeAttr('disabled')
        } else {
            alert('Sorry, the maximum value was reached');
            $(this).val($(this).data('oldValue'));
        }


    });
    $(".input-number").keydown(function (e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 190]) !== -1 ||
            // Allow: Ctrl+A
            (e.keyCode == 65 && e.ctrlKey === true) ||
            // Allow: home, end, left, right
            (e.keyCode >= 35 && e.keyCode <= 39)) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    });
});