using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPractice
{
    public class ApiWebResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public object Response { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var response = new ApiWebResponse{Success = true, Response = 1};

            var number = (int) response.Response;

            Console.ReadLine();
        }
    }

}
