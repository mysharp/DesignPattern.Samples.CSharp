﻿using System.Collections.Generic;

namespace EDC.DesignPattern.Iterator
{
    /// <summary>
    ///     具体聚合类：ProductList
    /// </summary>
    public class ProductList : AbstractObjectList
    {
        public ProductList(IList<object> objectList) : base(objectList)
        {
        }

        public override AbstractIterator CreateIterator()
        {
            return new ProductIterator(this);
        }

        /// <summary>
        ///     内部类=>具体迭代器：ProductIterator
        /// </summary>
        private class ProductIterator : AbstractIterator
        {
            private int cursor1; // 定义一个游标，用于记录正向遍历的位置
            private int cursor2; // 定义一个游标，用于记录逆向遍历的位置
            private ProductList productList;
            private readonly IList<object> products;

            public ProductIterator(ProductList productList)
            {
                this.productList = productList;
                products = productList.GetObjectList(); // 获取集合对象
                cursor1 = 0; // 设置正向遍历游标的初始值
                cursor2 = products.Count - 1; // 设置逆向遍历游标的初始值
            }

            public object GetNextItem()
            {
                return products[cursor1];
            }

            public object GetPreviousItem()
            {
                return products[cursor2];
            }

            public bool IsFirst()
            {
                return cursor2 == -1;
            }

            public bool IsLast()
            {
                return cursor1 == products.Count;
            }

            public void Next()
            {
                if (cursor1 < products.Count) cursor1++;
            }

            public void Previous()
            {
                if (cursor2 > -1) cursor2--;
            }
        }
    }
}