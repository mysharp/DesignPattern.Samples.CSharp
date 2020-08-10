using System.Collections.Generic;

namespace EDC.DesignPattern.Iterator
{
    /// <summary>
    ///     抽象聚合类：AbstractObjectList
    /// </summary>
    public abstract class AbstractObjectList
    {
        protected IList<object> objectList = new List<object>();

        public AbstractObjectList(IList<object> objectList)
        {
            this.objectList = objectList;
        }

        public void AddObject(object obj)
        {
            objectList.Add(obj);
        }

        public void RemoveObject(object obj)
        {
            objectList.Remove(obj);
        }

        public IList<object> GetObjectList()
        {
            return objectList;
        }

        // 声明创建迭代器对象的抽象工厂方法
        public abstract AbstractIterator CreateIterator();
    }
}