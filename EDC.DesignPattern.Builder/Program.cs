using System;

namespace EDC.DesignPattern.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = (ActorBuilder) AppConfigHelper.GetConcreteBuilderInstance();
            var director = new ActorController();
            var actor = director.Construct(builder);

            Console.WriteLine("角色类型：{0}", actor.Type);
            Console.WriteLine("角色性别：{0}", actor.Sex);
            Console.WriteLine("角色面容：{0}", actor.Face);
            Console.WriteLine("角色服装：{0}", actor.Costume);
            Console.WriteLine("角色发型：{0}", actor.HairStyle);

            Console.ReadKey();
        }
    }
}