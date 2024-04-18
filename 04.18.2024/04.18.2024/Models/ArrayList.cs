using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._18._2024.Models
{
    internal class ArrayList
    {
        int[] _arr;
        public int Capacity { get; set; }
        public int Count { get; private set; }
        public ArrayList()
        {
            Capacity = 3;

            _arr = new int[Capacity];
        }
        public ArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public int this[int num]
        {
            get { return _arr[Count]; }
            set { _arr[Count] = value; }

        }
        public void Add(int item)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Capacity + Count);
            }
            _arr[Count] = item;
            Count++;

        }
        public void GetInfo()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public void IndexOf(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i] == value)
                {
                    Console.WriteLine(i);
                    break;
                }
            }



        }
        public void LastIndexOf(int value2)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (_arr[i] == value2)
                {
                    Console.WriteLine(i);
                    break;
                }

            }


        }
        public  void RemoveAt(int index)
        {
            _arr[index] = 0;
        }


        public override string ToString()
        {
            string result = "{";
            for (int i = 0; i < Count; i++)
            {
                if (i > 0)
                {
                    result += ", ";
                }
                result += _arr[i].ToString();

            }
            result += "}";
            return result;
        }
    }
}
