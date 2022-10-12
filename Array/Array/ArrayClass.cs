using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Array
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            ArrayLList nombreC = new ArrayLList();
            ArrayListIterator iterator;
            ArrayListIterator iterator2;
        
            nombreC.addAtTail("Miguel"); //Agregamos nombres a la lista
            nombreC.addAtTail("Lopez");
            nombreC.addAtTail("Licea");
            
         
            iterator = nombreC.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);    //Debe de imprimir mi nombre completo
            }

            Console.WriteLine("La lista tiene " + nombreC.getSize() + " elementos");

            nombreC.remove(1);


            iterator2 = nombreC.getIterator();

            while (iterator2.hasNext())
            {
                String name = iterator2.next();
                Console.WriteLine(name);    //Debe de imprimir mi nombre sin el Lopez
            }

            Console.WriteLine("La lista ahora tiene " + nombreC.getSize() + " elementos");
        }
    }
}