# ProductsSelector
# ================
#
# The `ProductsSelector` selects items by their product ID.
#
# Example
# -------
#   * Items where the product ID is either 100, 200 or 301
#
class ProductsSelector
  def initialize(product_ids)
    @product_ids = Array(product_ids)
  end
  def match?(line_item)
    @product_ids.include?(line_item.variant.product.id)
  end
end
