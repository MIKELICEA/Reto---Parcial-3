using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace List.LinkedLList
{
    class List
    {
        static void Main(string[] args)
        {
            LinkedLList linkedList = new LinkedLList();
            LinkedListIterator iterator;
            LinkedListIterator iterato2;

            linkedList.addAtFront("Licea");
            linkedList.addAtFront("Lopez");
            linkedList.addAtFront("Miguel");
        
            iterator = linkedList.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name); //Debe imprimir mi nombre comleto
            }

            Console.WriteLine("La linked list tiene: " + linkedList.getSize() + " elementos"); 
            Console.WriteLine();

            linkedList.remove(1);


            if (linkedList.getAt(1).Equals("Licea"))
            {
                linkedList.setAt(1,"Montoya"); //Cambia Licea por Montoya
            }

            iterato2 = linkedList.getIterator();

            while (iterato2.hasNext())
            {
                String name = iterato2.next();
                Console.WriteLine(name); //Debe imprimir Miguel Montoya
            }
        }
    }
}