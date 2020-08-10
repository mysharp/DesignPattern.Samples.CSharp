using System;

namespace EDC.DesignPattern.Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var searcher = AppConfigHelper.GetProxyInstance() as ISearcher;
            if (searcher != null)
            {
                var result = searcher.DoSearch("杨过", "玉女心经");
            }

            Console.ReadKey();
        }
    }
}