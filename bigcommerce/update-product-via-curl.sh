#!/usr/bin/env bash
curl --request PUT \
  --url https://api.bigcommerce.com/stores/h79347hr0f/v3/catalog/products/130 \
  --header 'accept: application/json' \
  --header 'content-type: application/json' \
  --header 'x-auth-client: clientid' \
  --header 'x-auth-token: access-token' \
  --data "{\"name\":\"Elmer's® - \\\"Glue\\\" - School Glue & Paste, 8 oz - Elmers Glue\"}"