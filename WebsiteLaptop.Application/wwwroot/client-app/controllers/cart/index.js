var CartController = function () {
    var cachedObj = {
        productConditions: [],
    }
    this.initialize = function () {
        $.when(loadProductConditions())
            .then(function () {
                loadData();
            });

        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-delete', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            $.ajax({
                url: '/Cart/RemoveFromCart',
                type: 'post',
                data: {
                    productId: id
                },
                success: function () {
                    common.notify('Removing product is successful.', 'success');
                    loadHeaderCart();
                    loadData();
                }
            });
        });
        $('body').on('keyup', '.txtQuantity', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var q = $(this).val();
            if (q > 0) {
                $.ajax({
                    url: '/Cart/UpdateCart',
                    type: 'post',
                    data: {
                        productId: id,
                        quantity: q
                    },
                    success: function () {
                        common.notify('Update quantity is successful', 'success');
                        loadHeaderCart();
                        loadData();
                    }
                });
            } else {
                common.notify('Your quantity is invalid', 'error');
            }

        });

        $('body').on('change', '.ddlProductConditionId', function (e) {
            e.preventDefault();
            var id = parseInt($(this).closest('tr').data('id'));
            var productConditionId = $(this).val();
            var q = $(this).closest('tr').find('.txtQuantity').first().val();

            if (q > 0) {
                $.ajax({
                    url: '/Cart/UpdateCart',
                    type: 'post',
                    data: {
                        productId: id,
                        quantity: q,
                        productCondition: productConditionId
                    },
                    success: function () {
                        common.notify('Update quantity is successful', 'success');
                        loadHeaderCart();
                        loadData();
                    }
                });
            } else {
                common.notify('Your quantity is invalid', 'error');
            }

        });

        $('#btnClearAll').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: '/Cart/ClearCart',
                type: 'post',
                success: function () {
                    common.notify('Clear cart is successful', 'success');
                    loadHeaderCart();
                    loadData();
                }
            });
        });
    }
    function loadProductConditions() {
        return $.ajax({
            type: "GET",
            url: "/Cart/GetProductConditions",
            dataType: "json",
            success: function (response) {
                cachedObj.productConditions = response;
            },
            error: function () {
                common.notify('Has an error in progress', 'error');
            }
        });
    }

    function getProductConditionOptions(selectedId) {
        var productConditions = "<select class='form-control ddlProductConditionId'><option value='0'></option>";
        $.each(cachedObj.productConditions, function (i, productCondition) {
            if (selectedId === productCondition.Id)
                productConditions += '<option value="' + productCondition.Id + '" selected="select">' + productCondition.Name + '</option>';
            else
                productConditions += '<option value="' + productCondition.Id + '">' + productCondition.Name + '</option>';
        });
        productConditions += "</select>";
        return productConditions;
    }

    function loadHeaderCart() {
        $("#headerCart").load("/AjaxContent/HeaderCart");
    }

    function loadData() {
        $.ajax({
            url: '/Cart/GetCart',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                var template = $('#template-cart').html();
                var render = "";
                var totalAmount = 0;
                $.each(response, function (i, item) {
                    render += Mustache.render(template,
                        {
                            ProductId: item.Product.Id,
                            ProductName: item.Product.Name,
                            Image: item.Product.Image,
                            Price: common.formatNumber(item.Price, 0),
                            Quantity: item.Quantity,
                            ProductConditions: getProductConditionOptions(item.ProductCondition == null ? 0 : item.ProductCondition.Id),
                            Amount: common.formatNumber(item.Price * item.Quantity, 0),
                            Url: '/' + item.Product.SeoAlias + "-p." + item.Product.Id + ".html"
                        });
                    totalAmount += item.Price * item.Quantity;
                });
                $('#lblTotalAmount').text(common.formatNumber(totalAmount, 0));
                if (render !== "")
                    $('#table-cart-content').html(render);
                else
                    $('#table-cart-content').html('You have no product in cart');
            }
        });
        return false;
    }
} 