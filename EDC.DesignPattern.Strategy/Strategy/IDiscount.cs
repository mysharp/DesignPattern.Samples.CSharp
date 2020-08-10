namespace EDC.DesignPattern.Strategy
{
    /// <summary>
    ///     抽象策略类：折扣Discount
    /// </summary>
    public interface IDiscount
    {
        double Calculate(double price);
    }
}