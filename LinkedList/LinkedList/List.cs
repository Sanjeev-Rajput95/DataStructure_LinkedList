using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class List
    {
        LinkedList<int> listName = new LinkedList<int>();

        public void add()
        {
            listName.AddLast(56);
            listName.AddLast(30);
            listName.AddLast(70);

            foreach (int num in listName)
            {
                Console.WriteLine(num);
            }
        }
    }
}
