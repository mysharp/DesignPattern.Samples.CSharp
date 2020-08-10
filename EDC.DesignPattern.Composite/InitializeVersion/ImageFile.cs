using System;

namespace EDC.DesignPattern.Composite.InitializeVersion
{
    public class ImageFile
    {
        private readonly string name;

        public ImageFile(string name)
        {
            this.name = name;
        }

        public void KillVirus()
        {
            // 此处模拟杀毒操作
            Console.WriteLine("---- 对图像文件‘{0}’进行杀毒", name);
        }
    }

    public class TextFile
    {
        private readonly string name;

        public TextFile(string name)
        {
            this.name = name;
        }

        public void KillVirus()
        {
            // 此处模拟杀毒操作
            Console.WriteLine("---- 对文本文件‘{0}’进行杀毒", name);
        }
    }
}