﻿using System;
using EDC.DesignPattern.Builder;
using EDC.DesignPattern.FactoryMethod.v1;
using EDC.DesignPattern.FactoryMethod.v3;

namespace EDC.DesignPattern.FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // v1.0
            //ClientVersion1();

            // v2.0
            //ClientVersion2();

            // v3.0
            ClientVersion3();

            Console.ReadKey();
        }

        public static void ClientVersion1()
        {
            ILoggerFactory factory = new FileLoggerFactory(); // 可通过引入配置文件实现
            if (factory == null) return;

            var logger = factory.CreateLogger();
            logger.WriteLog();
        }

        public static void ClientVersion2()
        {
            var factory = (ILoggerFactory) AppConfigHelper.GetLoggerFactoryInstance();
            if (factory == null) return;

            var logger = factory.CreateLogger();
            logger.WriteLog();
        }

        public static void ClientVersion3()
        {
            var factory = (LoggerFactory) AppConfigHelper.GetLoggerFactoryInstance();
            if (factory == null) return;

            factory.WriteLog();
        }
    }
}