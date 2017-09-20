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
            var list = new MyList();
            list.AddInt(10);
            list.AddInt(20);
            list.AddInt(30);
            list.AddInt(40);
            list.AddInt(50);
            list.AddInt("test");

            var f = (int)list.getNumber(0);
            var g = (int)list.getNumber(5); //cannot convert string to int , error will occur on runtime. type is not safe.
            var result = f * g;

            Console.WriteLine(list.getNumber(2));
        }
    }

    public class MyList
    {
        private List<object> mNumbers = new List<object>();

        public void AddInt(object number)
        {
            mNumbers.Add(number);
        }

        public object getNumber(int i)
        {
            return mNumbers[i];
        }
    }

}
