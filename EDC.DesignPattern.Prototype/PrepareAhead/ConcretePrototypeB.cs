using System;

namespace EDC.DesignPattern.Prototype.PrepareAhead
{
    public class ConcretePrototypeB : ICloneable
    {
        public ConcretePrototype a = new ConcretePrototype();
        public string customAttr = "hello prototype";
        public int i;

        public object Clone()
        {
            // 实现深复制-方式1：依次赋值和实例化
            var newObj = new ConcretePrototypeB();
            newObj.a = new ConcretePrototype();
            newObj.a.CustomAttr = a.CustomAttr;
            newObj.i = i;

            return newObj;
        }

        public new object MemberwiseClone()
        {
            // 实现浅复制
            return base.MemberwiseClone();
        }

        public override string ToString()
        {
            var result = string.Format("I的值为{0},A为{1}", i.ToString(), a.CustomAttr);
            return result;
        }
    }
}