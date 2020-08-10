﻿using System;

namespace EDC.DesignPattern.Observer
{
    public class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName)
        {
            Console.WriteLine("系统通知：{0} 战队组建成功！", AllyName);
            Console.WriteLine("-------------------------------------------------------");
            AllyName = allyName;
        }

        // 实现通知方法
        public override void NotifyObserver(string playerName)
        {
            Console.WriteLine("通知：盟友们，{0} 正遭受敌军攻击，速去抢救！", playerName);
            foreach (var player in playerList)
                if (!player.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase))
                    player.Help();
        }
    }
}