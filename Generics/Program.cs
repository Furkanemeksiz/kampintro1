using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }

    }
    class MyList<T>
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _array = new T[_array.Length + 1]; 
        }
        private int myVar;

        public int MyProperty
        {
            get { return _array.Length; }
            
        }

    }
}
