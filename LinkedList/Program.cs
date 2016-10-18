using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //Console.WriteLine("Is the list empty?  - " +  list.Empty);
            //Console.WriteLine("The size of the list is - " +  list.Count);

            list.Add("test1");
            list.Add("test2");
            list.Add(1, "testA");

            int index = list.IndexOf ("test2");
            bool isContains = list.Contails("testA");

            list.Get(1);

            list.Clear();
        }
    }
}
