using System;
using System.IO;
using System.Text;

namespace EDC.DesignPattern.Facade
{
    /// <summary>
    ///     文件保存类：子系统C
    /// </summary>
    public class FileWriter
    {
        public void Write(string encryptedStr, string fileNameDes)
        {
            Console.WriteLine("保存密文，写入文件：");
            var myByte = Encoding.UTF8.GetBytes(encryptedStr);
            using (var fsWrite = new FileStream(fileNameDes, FileMode.Append))
            {
                fsWrite.Write(myByte, 0, myByte.Length);
            }

            ;

            Console.WriteLine("写入文件成功：100%");
        }
    }
}