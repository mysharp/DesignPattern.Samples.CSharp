﻿using System;
using System.Collections.Generic;

namespace EDC.DesignPattern.Singleton
{
    /// <summary>
    ///     假装自己是一个负载均衡器
    /// </summary>
    public class LoadBalancer
    {
        // 获得一台Server - 使用随机数获取
        private readonly Random rand = new Random();

        // 私有静态变量，存储唯一实例
        //private static LoadBalancer instance = null;
        //private static readonly LoadBalancer instance = new LoadBalancer();
        //private static readonly object syncLocker = new object();
        // 服务器集合
        private readonly IList<CustomServer> serverList;

        // 私有构造函数
        private LoadBalancer()
        {
            serverList = new List<CustomServer>();
        }

        // 公共静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            // 第一重判断
            //if (instance == null)
            //{
            //    // 锁定代码块
            //    lock (syncLocker)
            //    {
            //        // 第二重判断
            //        if (instance == null)
            //        {
            //            instance = new LoadBalancer();
            //        }
            //    }
            //}
            //return instance;
            return Nested.instance;
        }

        // 添加一台Server
        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }

        // 移除一台Server
        public void RemoveServer(string serverName)
        {
            foreach (var server in serverList)
                if (server.Name.Equals(serverName))
                {
                    serverList.Remove(server);
                    break;
                }
        }

        public CustomServer GetServer()
        {
            var index = rand.Next(serverList.Count);

            return serverList[index];
        }

        // 使用内部类+静态构造函数实现延迟初始化
        // 当第一次用到这个嵌套类型的时候，会调用静态构造函数创建LoadBalancer的实例instance。如果我们不调用属性LoadBalancer.GetLoadBalancer()，那么就不会触发.NET运行时（CLR）调用Nested，也就不会创建实例，因此也就保证了按需创建实例（或延迟初始化）
        private class Nested
        {
            internal static readonly LoadBalancer instance = new LoadBalancer();

            static Nested()
            {
            }
        }
    }
}