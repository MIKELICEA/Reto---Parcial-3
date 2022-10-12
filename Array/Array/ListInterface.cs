using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal interface ListInterface
    {
        void addAtTail(String data);
        void addAtFront(String data);
        void removeAll();
        void remove(int index);
        void setAt(int index, String data);
        String getAt(int index);
        ArrayListIterator getIterator();
        int getSize();
    }
}
