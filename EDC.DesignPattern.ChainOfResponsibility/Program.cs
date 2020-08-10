﻿using System;

namespace EDC.DesignPattern.ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 创建职责链
            Approver andy = new Director("Andy");
            Approver jacky = new Manager("Jacky");
            Approver ashin = new VicePresident("Ashin");
            Approver anya = new President("Anya");
            Approver meeting = new Congress("Congress");

            andy.SetSuccessor(jacky);
            jacky.SetSuccessor(ashin);
            ashin.SetSuccessor(anya);
            anya.SetSuccessor(meeting);
            // 构造采购请求单并发送审批请求
            var request1 = new PurchaseRequest(45000.00,
                "MANULIFE201706001",
                "购买PC和显示器");
            andy.ProcessRequest(request1);

            var request2 = new PurchaseRequest(60000.00,
                "MANULIFE201706002",
                "2017开发团队活动");
            andy.ProcessRequest(request2);

            var request3 = new PurchaseRequest(160000.00,
                "MANULIFE201706003",
                "2017公司年度旅游");
            andy.ProcessRequest(request3);

            var request4 = new PurchaseRequest(800000.00,
                "MANULIFE201706004",
                "租用新临时办公楼");
            andy.ProcessRequest(request4);

            Console.ReadKey();
        }

        public static void InitializeDemo(PurchaseRequest request)
        {
            var requestHandler = new PurchaseRequestHandler();
            requestHandler.SendRequestToApprover(request);
        }
    }
}