fetch(`/api/storefront/cart`, {
    method: "POST",
    credentials: "same-origin",
    headers: {
        "Content-Type": "application/json"
    },
    body: JSON.stringify({
        "lineItems": [
            {
                "quantity": 1,
                "productId": 80
            }
        ]
    }),
})
.then(response => response.json())
.then(function (data) {
    console.log(JSON.stringify(data));
    if (data.status == 422) {
        alert("Product Already in Cart");
    }
})
.catch(error => console.error(error));


fetch('/api/storefront/cart', { credentials: 'same-origin' })
.then(function (r) { return r.json(); })
.then(function (cart) {
    if(!cart || (cart && cart.length == 0)) {
       console.log('cart is empty');
       return;
    }
    fetch(`/api/storefront/carts/${cart[0].id}`, {
        method: "DELETE",
        credentials: "same-origin",
        headers: {"Content-Type": "application/json"}
    })
    .then(response => response.text())
    .then(function (data) {
        console.log("DELETE CART: " + data);
    })
    .catch(error => console.error(error));
});



fetch('/api/storefront/cart', { credentials: 'same-origin' })
.then(function (r) { return r.json(); })
.then(function (cart) {
    if(!cart || (cart && cart.length == 0)) {
       console.log('cart is empty');
       return;
    }
    fetch(`/api/storefront/carts/${cart[0].id}/items`, {
        method: "POST",
        credentials: "same-origin",
        headers: {"Content-Type": "application/json"},
        body: JSON.stringify({
            "lineItems": [
                {
                    "quantity": 1,
                    "productId": 80
                }
            ]
        })
    })
    .then(response => response.json())
    .then(function (data) {
        console.log("Add second item to cart: " + JSON.stringify(data, null, 2));
    })
    .catch(error => console.error(error));
});

