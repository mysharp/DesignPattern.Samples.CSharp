using System;

namespace EDC.DesignPattern.Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Intialize();

            Extended();

            Console.ReadKey();
        }

        public static void Intialize()
        {
            // Step1.定义中介者对象
            var mediator = new ConcreteMediator();

            // Step2.定义同事对象
            var addButton = new Button();
            var list = new List();
            var cb = new ComboBox();
            var userNameTextBox = new TextBox();

            addButton.SetMediator(mediator);
            list.SetMediator(mediator);
            cb.SetMediator(mediator);
            userNameTextBox.SetMediator(mediator);

            mediator.addButton = addButton;
            mediator.list = list;
            mediator.cb = cb;
            mediator.userNameTextBox = userNameTextBox;

            // Step3.点击增加按钮
            addButton.Changed();

            Console.WriteLine("---------------------------------------------");

            // Step4.从列表框选择客户
            list.Changed();
        }

        public static void Extended()
        {
            // Step1.定义中介者对象
            var mediator = new SubConcreteMediator();

            // Step2.定义同事对象
            var addButton = new Button();
            var list = new List();
            var cb = new ComboBox();
            var userNameTextBox = new TextBox();
            var label = new Label();

            addButton.SetMediator(mediator);
            list.SetMediator(mediator);
            cb.SetMediator(mediator);
            userNameTextBox.SetMediator(mediator);
            label.SetMediator(mediator);

            mediator.addButton = addButton;
            mediator.list = list;
            mediator.cb = cb;
            mediator.userNameTextBox = userNameTextBox;
            mediator.label = label;

            // Step3.点击增加按钮
            addButton.Changed();

            Console.WriteLine("---------------------------------------------");

            // Step4.从列表框选择客户
            list.Changed();
        }
    }
}