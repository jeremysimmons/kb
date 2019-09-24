 <script>
// remove single items in cart
async function removeItem(cartid, lineid) {
    var url = '/api/storefront/carts/' + cartid + '/items/' + lineid;
    console.log('removeItem: ' + url);
    await fetch(url, {
        credentials: 'include',
        method: 'DELETE',
        headers:{'Content-Type': 'application/json'}
    })
    .then(function(response) { return response.status == 200 ? response.json() : response.text(); })
    .then(function(myJson) { console.log(myJson ? JSON.stringify(myJson, null, 2) : "<empty>"); });
    console.log('removeItem finished');
}
// remove all items in cart
async function removeAllItems() {
    fetch('/api/storefront/cart', { credentials: 'include' })
    .then(function (r) { return r.json(); })
    .then(async function (cartResponse) {
        if(!cartResponse || (cartResponse && cartResponse.length == 0)) {
            console.log('removeAllItems: empty cart');
            return;
        } else {
            var cart = cartResponse[0];
            var cartid = cart.id;
            var lines = cart.lineItems;
            // product pick list options add phantom line items with 0 quantity
            if(lines.physicalItems) 
            {
                for(l of lines.physicalItems) 
                {
                    console.log('found ' + l.name);
                    await removeItem(cartid, l.id);
                    console.log('removed ' + l.name);
                }
            }
            if(lines.digitalItems)
            {
                for(l of lines.digitalItems) 
                {
                    console.log('found ' + l.name);
                    await removeItem(cartid, l.id);
                    console.log('removed ' + l.name);
                }
            }
        }
    });
}
function addToCart(items) {
    fetch('/api/storefront/cart', { credentials: 'include' })
    .then(function (r) { return r.json(); })
    .then(function (cart) {
        var url = '';
        if(!cart || (cart && cart.length == 0)) {
            url = '/api/storefront/cart';
        } else {
            url = '/api/storefront/carts/'+cart[0].id+'/items';
        }
        fetch(url, {
            credentials: 'include',
            method: 'POST',
            headers:{'Content-Type': 'application/json'},
            body: JSON.stringify({ 'lineItems': items})
        })
        .then(function (r) { return r.json(); })
        .then(function (data) {
            console.log('after add items: ' + JSON.stringify(data, null, 2));
        });
    });
}
// get cart contents
function printCart()
{
    fetch('/api/storefront/cart?include=lineItems.digitalItems.options,lineItems.physicalItems.options',{credentials: 'include'})
    .then(function(response) {return response.json();})
    .then(function(cart) {
        if(!cart || (cart && cart.length == 0)) {
            console.log('empty cart');
        } else { 
            console.log(JSON.stringify(cart, null, 2));
        }
    });
}
</script>