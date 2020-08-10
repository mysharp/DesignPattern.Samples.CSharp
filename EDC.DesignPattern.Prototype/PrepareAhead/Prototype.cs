namespace EDC.DesignPattern.Prototype.PrepareAhead
{
    public abstract class Prototype
    {
        // 自定义成员
        public string CustomAttr { get; set; }

        public abstract Prototype Clone();
    }
}