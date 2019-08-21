function postData(url = '', checkoutId = '', billingId = '', data = {}, ) {
    var path = url + checkoutId + '/billing-address/' + billingId;
    console.log(path);
    return fetch(path, {
        method: 'PUT',
        credentials: 'same-origin',
        headers: {
            'Content-Type': 'application/json;',
        },
        body: JSON.stringify(data),
    })
    .then(response => response.json());
}

var checkoutId = 'e2bbfec9-a70b-448b-bc9b-c27a12a10f29';
var businessAddressId = '5d3ae0847cfb1';
postData('/api/storefront/checkouts/', checkoutId, businessAddressId, {
    'first_name': 'John',
    'last_name': 'Doe',
    'email': 'test@test.com',
    'address1': '11305 Four Points Dr',
    'address2': 'Suite 300',
    'city': 'Austin',
    'state_or_province': 'Texas',
    'state_or_province_code': 'TX',
    'country_code': 'US',
    'postal_code': '78726',
    'phone': '5128654500',
    'customFields': [
        {
            "fieldId": "field_47",
            "fieldValue": "address 3"
        },
        {
            "fieldId": "field_41",
            "fieldValue": "Reseller (DGXX)"
        },
        {
            "fieldId": "field_45",
            "fieldValue": "Unassigned Customer-web (9990)"
        },
        {
            "fieldId": "field_49",
            "fieldValue": "Campaign Code"
        }
    ]
})
.then(data => console.log(JSON.stringify(data, null, 2)))
.catch(error => console.error(error));
