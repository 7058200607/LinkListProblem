using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblem
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Do LinkList Operation ");
            LinkList linklist =new LinkList();
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);
            linklist.Display();
            /*Console.WriteLine("Append data and display data in 56-30-70");

            linklist.Appending(56);
            linklist.Appending(30);
            linklist.Appending(70);
            linklist.Display();

            Console.WriteLine("Insert a data into perticular postion ");

             linklist.InsertAtPerticularPosition(30, 2);
            linklist.Display();
            */
            Console.WriteLine("Delete First element from Link List ");
            linklist.pop_front();
            linklist.Display();
       
        }

    }
}
    
