using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var skinFactory = (ISkinFactory) AppConfigHelper.GetSkinFactoryInstance();
            if (skinFactory == null) Console.WriteLine("read the skin failed...");

            var button = skinFactory.CreateButton();
            var textField = skinFactory.CreateTextField();
            var comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}