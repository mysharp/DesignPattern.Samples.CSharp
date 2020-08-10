namespace EDC.DesignPattern.AbstractFactory
{
    public interface ISkinFactory
    {
        IButton CreateButton();

        ITextField CreateTextField();

        IComboBox CreateComboBox();
    }
}