namespace EDC.DesignPattern.Strategy
{
    /// <summary>
    ///     环境类：电影票MovieTicket
    /// </summary>
    public class MovieTicket
    {
        private IDiscount _discount;
        private double _price;

        public double Price
        {
            get => _discount.Calculate(_price);
            set => _price = value;
        }

        public IDiscount Discount
        {
            set => _discount = value;
        }
    }
}