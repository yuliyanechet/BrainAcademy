using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MyClass
    {
        public object[] arr;
        int count = 0;

        public void Delete(int index)
        {
            object[] temp = new object[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (index != i)
                {
                    temp[count] = arr[i];
                    count++;
                };
            }
            count = 0;
            arr = temp;
        }

        public void AddRange(object[] addElements)
        {
            object[] temp = new object[arr.Length + addElements.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            for (int j = 0; j < addElements.Length; j++)
            {
                temp[j + arr.Length] = addElements[j];
            }

            arr = temp;
        }

        public bool Contain(object search)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == search.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public void IndexOf(object number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == number.ToString())
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Sort()
        {
            int[] temp = new int[arr.Length];

            for (int x=0; x< arr.Length;x++)
            {
                temp[x] = Convert.ToInt32(arr[x]);
            }
            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (temp[i - 1] > temp[i])
                    {
                        int third = temp[i - 1];
                        temp[i - 1] = temp[i];
                        temp[i] = third;
                    }
                }            
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}
