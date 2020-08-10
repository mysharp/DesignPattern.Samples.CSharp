using System;

namespace EDC.DesignPattern.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoadBalancer balancer, balancer2, balancer3;
            balancer = LoadBalancer.GetLoadBalancer();
            balancer2 = LoadBalancer.GetLoadBalancer();
            balancer3 = LoadBalancer.GetLoadBalancer();

            // 判断负载均衡器是否相同
            if (balancer == balancer2 && balancer == balancer3 && balancer2 == balancer3)
                Console.WriteLine("^_^ : the balancer is single！");

            // 增加服务器
            balancer.AddServer(new CustomServer {Name = "Server 1"});
            balancer.AddServer(new CustomServer {Name = "Server 2"});
            balancer.AddServer(new CustomServer {Name = "Server 3"});
            balancer.AddServer(new CustomServer {Name = "Server 4"});

            // 模拟客户端请求的分发
            for (var i = 0; i < 10; i++)
            {
                var server = balancer.GetServer();
                Console.WriteLine("the request is assigned to : " + server.Name);
            }

            Console.ReadKey();
        }
    }
}