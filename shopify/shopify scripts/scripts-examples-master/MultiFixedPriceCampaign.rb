class MultiFixedPriceCampaign
  def initialize(prices, message)
    @prices = prices
    @message = message
  end

  def run(cart)
    cart.line_items.each do |line_item|
      product = line_item.variant.product
      next if product.gift_card?
      next unless @prices.has_key?(product.id)
      line_item.change_line_price(Money.new(cents: @prices.fetch(product.id)), message: @message)
    end
  end
end
