using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISkinFactory skinFactory = (ISkinFactory) AppConfigHelper.GetSkinFactoryInstance();
            if (skinFactory == null)
            {
                Console.WriteLine("read the skin failed...");
            }

            IButton button = skinFactory.CreateButton();
            ITextField textField = skinFactory.CreateTextField();
            IComboBox comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}
