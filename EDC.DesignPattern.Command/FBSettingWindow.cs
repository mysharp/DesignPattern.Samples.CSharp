using System;
using System.Collections.Generic;

namespace EDC.DesignPattern.Command
{
    /// <summary>
    ///     功能键设置窗口类
    /// </summary>
    public class FBSettingWindow
    {
        // 所有功能键集合
        private readonly IList<FunctionButton> functionButtonList = new List<FunctionButton>();

        public FBSettingWindow(string title)
        {
            Title = title;
        }

        // 窗口标题
        public string Title { get; set; }

        public void AddFunctionButton(FunctionButton fb)
        {
            functionButtonList.Add(fb);
        }

        public void RemoveFunctionButton(FunctionButton fb)
        {
            functionButtonList.Remove(fb);
        }

        // 显示窗口及功能键
        public void Display()
        {
            Console.WriteLine("显示窗口：{0}", Title);
            Console.WriteLine("显示功能键：");

            foreach (var fb in functionButtonList) Console.WriteLine(fb.Name);

            Console.WriteLine("------------------------------------------");
        }
    }
}