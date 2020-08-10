using System;
using System.IO;
using System.Text;

namespace EDC.DesignPattern.Facade
{
    /// <summary>
    ///     文件读取类：子系统A
    /// </summary>
    public class FileReader
    {
        public string Read(string fileNameSrc)
        {
            Console.WriteLine("读取文件，获取明文：");
            var result = string.Empty;
            using (var fsRead = new FileStream(fileNameSrc, FileMode.Open))
            {
                var fsLen = (int) fsRead.Length;
                var heByte = new byte[fsLen];
                var r = fsRead.Read(heByte, 0, heByte.Length);
                result = Encoding.UTF8.GetString(heByte);
            }

            return result;
        }
    }
}