using System;

namespace EDC.DesignPattern.TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = AppConfigHelper.GetAccountInstance() as Account;
            if (account != null) account.Handle("张无忌", "123456");

            Console.ReadKey();
        }
    }
}