namespace EDC.DesignPattern.Mediator
{
    /// <summary>
    ///     抽象中介者
    /// </summary>
    public abstract class Mediator
    {
        public abstract void ComponenetChanged(Component c);
    }
}