using System;
using System.Collections.Generic;

namespace EDC.DesignPattern.Observer
{
    /// <summary>
    ///     抽象目标类：战队控制中心
    /// </summary>
    public abstract class AllyControlCenter
    {
        protected IList<IObserver> playerList = new List<IObserver>();
        public string AllyName { get; set; }

        public void Join(IObserver observer)
        {
            playerList.Add(observer);
            Console.WriteLine("通知：{0} 加入 {1} 战队", observer.Name, AllyName);
        }

        public void Quit(IObserver observer)
        {
            playerList.Remove(observer);
            Console.WriteLine("通知：{0} 退出 {1} 战队", observer.Name, AllyName);
        }

        // 声明抽象通知方法
        public abstract void NotifyObserver(string name);
    }
}