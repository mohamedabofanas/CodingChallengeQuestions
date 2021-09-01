using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//insert a node in a singly-linked list at a given point in the linked list
namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the node value");
            var nodeValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the node Posotion");
            var nodePosotion = Convert.ToInt32(Console.ReadLine());

            InsertNode(nodeValue, nodePosotion);

            Console.ReadLine();
        }

        static void InsertNode(int value, int position)
        {
            var linkedList = new List<int> { 2, 5, 10, 3, 6 };

            if (position > 1 && position <= linkedList.Count)
                linkedList.Insert(--position, value);
            else
                return;

            for (int i = 0; i < linkedList.Count; i++)
                Console.Write($"\n{linkedList[i]} ");
        }
    }
}
