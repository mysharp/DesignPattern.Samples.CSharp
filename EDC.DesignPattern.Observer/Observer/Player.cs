using System;

namespace EDC.DesignPattern.Observer
{
    /// <summary>
    ///     具体观察者类：战队成员
    /// </summary>
    public class Player : IObserver
    {
        public string Name { get; set; }

        public void BeAttacked(AllyControlCenter acc)
        {
            Console.WriteLine("{0}：我正被攻击，速来援救！", Name);
            // 调用战队控制中心类的通知方法来通知盟友
            acc.NotifyObserver(Name);
        }

        public void Help()
        {
            Console.WriteLine("{0} ：坚持住，立马来救你！", Name);
        }
    }
}