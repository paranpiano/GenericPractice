using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            var f = list.Getmember(0);
            var g = list.Getmember(4); //no need to convert
            var result = f * g;
            Console.WriteLine(f);


            var list2 = new MyList<string>();
            list2.Add("A"); //no need to convert
            list2.Add("B");

            Console.WriteLine(list2.Getmember(0));

        }
    }

    public class MyList<T>
    {
        private List<T> _collection = new List<T>();

        public void Add(T number)
        {
            _collection.Add(number);
        }

        public T Getmember(int i)
        {
            return _collection[i];
        }
    }

}
