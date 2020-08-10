using System;
using System.Text;

namespace EDC.DesignPattern.Facade
{
    /// <summary>
    ///     数据加密类：子系统B
    /// </summary>
    public class CipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.WriteLine("数据加密，将明文转换为密文：");
            var result = new StringBuilder();

            for (var i = 0; i < plainText.Length; i++)
            {
                var ch = Convert.ToString(plainText[i] % 7);
                result.Append(ch);
            }

            var encryptedResult = result.ToString();
            Console.WriteLine(encryptedResult);
            return encryptedResult;
        }
    }
}