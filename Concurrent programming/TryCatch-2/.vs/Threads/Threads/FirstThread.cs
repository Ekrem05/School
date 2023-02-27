using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class FirstThread
    {
        private string[] Foods { get; set; }
        private string[] Beverages { get; set; }
        public FirstThread()
        {
            Beverages = new string[10];
            Foods = new string[10];
        }
        public void DoTask1()
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                Foods[i] = input[i];
            }

        }
        public void DoTask2()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                Beverages[i] = input[i];
            }

        }
        public  void Print()
        {
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < Foods.Length; i++)
            {
                sb.AppendLine(Foods[i] + " ");
            }
            sb.AppendLine();
            for (int i = 0; i < Beverages.Length; i++)
            {
                sb.AppendLine(Beverages[i] + " ");
            }
            Console.WriteLine(   sb.ToString().TrimEnd());
        }
    }
}
