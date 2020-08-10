namespace EDC.DesignPattern.Decorator
{
    /// <summary>
    ///     构件装饰类：抽象装饰类
    /// </summary>
    public class ComponentDecorator : Component
    {
        private readonly Component component;

        public ComponentDecorator(Component component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}