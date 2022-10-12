using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayLList : ListInterface
    {
        private static int n = 10;
        private string[] array;
        private int size;

        public ArrayLList(int size)
        {
            array = new string[size];
        }

        public ArrayLList()
        {
            array = new string[n];
        }

        public void addAtTail(String data)
        {
            if (size == array.Length)
            {
                increaseArrayList();
            }

            array[size] = data;
            size++;
        }

        private void increaseArrayList()
        {
            String[] newArray = new String[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void addAtFront(String data)
        {
            if (size == array.Length)
            {
                increaseArrayList();
            }

            if (size >= 0)
            {
                for(int i=0;i< array.Length;i++){
                    array[i+1]=array[i];
                }
            }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0)
            {
                for (int i = index; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
            }
            array[size - 1] = null;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        public String getAt(int index)
        {
            if (index >= 0 && index < size)
            {
                return array[index];
            }
            else
            {
                return null;
            }
        }

        public void setAt(int index, String data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public int getSize()
        {
            return size;
        }

        public ArrayListIterator getIterator()
        {
            return new ArrayListIterator(this);
        }

    }
}
