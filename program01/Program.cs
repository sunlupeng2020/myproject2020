using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace program01
{
    class Program01
    {
        static void Main(string[] args)
        {
            //创建ArrayList集合对象arr1
            ArrayList arr1 = new ArrayList();
            //使用不同方法向集合添加多个元素
            arr1.Add(134);
            arr1.AddRange(new ArrayList() { "张三", "李四" });
            arr1.Insert(3, 'a');
            ErgoArr(arr1);
            //使用Count属性获取集合中元素的个数
            Console.WriteLine("arr1的实际长度为:" + arr1.Count);
            //使用Capacity属性获取集合的容量
            Console.WriteLine("arr1的容量为:" + arr1.Capacity);
            Console.ReadKey();
        }
        //定义一个方法ErgoArr()，在该方法中使用for循环遍历集合中的所有元素
        static void ErgoArr(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
