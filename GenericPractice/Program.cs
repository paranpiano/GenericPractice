using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPractice
{
    public class ApiWebResponse<TResponse>
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public TResponse Response { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //get number of friends
            var response = new ApiWebResponse<int>{Success = true, Response = 1};

            //get my username
            var response2 = new ApiWebResponse<string> { Success = true, Response = "luke" };

            var number = response.Response;
            var name = response2.Response;

            Console.ReadLine();
        }
    }

}
