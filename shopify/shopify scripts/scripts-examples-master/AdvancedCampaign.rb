class AdvancedPriceCampaign
  def initialize(prices, type, code)
    @prices = prices
    @code = code
    @type = type # fixed, new_price, percent
  end
  def should_run?(cart)
    Input.cart.discount_code && Input.cart.discount_code.code == @code
  end
  def run(cart)
    cart.line_items.each do |line_item|
      product = line_item.variant.product
      next if product.gift_card?
      next unless @prices.has_key?(product.id)
      new_price = Money.new(cents: 0)
      if @type == :new_price
        puts 'new price'
        new_price = Money.new(cents: @prices.fetch(product.id))
      elsif @type == :fixed
        puts 'fixed amount off'
        new_price = line_item.line_price - Money.new(cents: @prices.fetch(product.id))
      elsif @type == :percent
        puts 'percent off'
        new_price = line_item.line_price * (1-@prices.fetch(product.id))
      end
      line_item.change_line_price(new_price, message: @code)
    end
  end
end
CAMPAIGNS = [
  AdvancedPriceCampaign.new("JWW1217", :new_price, { 7343976257 => 1100, 8109140417 => 599, 7343979969 => 1200, 10162053569 => 599 }),
  AdvancedPriceCampaign.new("21DAYS17", :percent, { 7343965249 => 0.3 })
]
CAMPAIGNS.each do |c|
  if c.should_run?(Input.cart)
    c.run(Input.cart) 
  end
end
Output.cart = Input.cart