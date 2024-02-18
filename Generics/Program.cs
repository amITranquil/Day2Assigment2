using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");

            MyList<string> cities2 =new MyList<string>();
            cities2.Add("Adana");
            cities2.Add("Adana");
            cities2.Add("Adana");

            Console.WriteLine(cities2.Count);

            

            Console.ReadLine();
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item) 
        {
            _tempArray = _array;
            _array=new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
       
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
