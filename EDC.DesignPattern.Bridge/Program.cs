using System;

namespace EDC.DesignPattern.Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var image = (Image) AppConfigHelper.GetImageInstance();
            var imageImpl = (ImageImplementor) AppConfigHelper.GetEnvInstance();

            image.SetImageImplementor(imageImpl);
            image.ParstFile("小龙女");

            Console.ReadKey();
        }
    }
}