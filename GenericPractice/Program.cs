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
            var intNumbers = new MyIntList();
            intNumbers.AddInt(10);
            intNumbers.AddInt(20);
            intNumbers.AddInt(30);
            intNumbers.AddInt(40);
            intNumbers.AddInt(50);

            Console.WriteLine(intNumbers.getNumber(2));

            var stringNumbers = new MyStringList();
            stringNumbers.AddInt("A");
            stringNumbers.AddInt("B");
            stringNumbers.AddInt("C");
            stringNumbers.AddInt("D");
            stringNumbers.AddInt("E");

            Console.WriteLine(stringNumbers.getString(2));
        }
    }

    public class MyIntList
    {
        private List<int> mNumbers = new List<int>();

        public void AddInt(int number)
        {
            mNumbers.Add(number);
        }

        public int getNumber(int i)
        {
            return mNumbers[i];
        }
    }

    public class MyStringList
    {
        private List<string> mStrings = new List<string>();

        public void AddInt(string str)
        {
            mStrings.Add(str);
        }

        public string getString(int i)
        {
            return mStrings[i];
        }
    }
}
