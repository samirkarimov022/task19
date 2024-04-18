using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUlviMWork.Moduls
{
    internal class IntArrayList
    {
        int[] _arr;
        public int Capasity {  get; set; }
        public int Count { get; set; }
        public int this[int num]
        {
            get
            {
                return _arr[Count];
            }
            set
            {
                if (value <= Count)
                {
                _arr[Count] = value;
                }
                else
                {
                    Console.WriteLine("array bitib");
                }
            }
        }
        public IntArrayList()
        {
            Capasity = 5;
            _arr =new int[Capasity];
        } public IntArrayList(int capasity)
        {
            Capasity = capasity;
            _arr =new int[Capasity];
        }
        public void Add(int value)
        {
            if(_arr.Length == Count)
            {
                Array.Resize(ref _arr,Count + Capasity);
            }
                _arr[Count] = value;
                Count++;
        }
        public void GetInfo() 
        {
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public void IndexOf(int value)
        {
            bool result = false;
            int index = 0;
            for (int i = 0;i < Count;i++)
            {
                if (_arr[i] == value)
                {
                    index = i;
                    result = true;
                    break;
                }
                
            }
            if (result)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("arrayda tapilmadi");

            } 


        }
        public void LastIndexOf(int value2)
        {
            
            bool result = false;
            int index = 0;
            for (int i = Count;i > 0;i--)
            {
                if (_arr[i] == value2)
                {
                    index = i;
                    result = true;
                    break;
                }
                
            }
            if (result)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("arrayda tapilmadi");
            }
            

        }
        public void RemoveAt(int index)
        {
            _arr[index] = 0;
        }


        public override string ToString()
        {
            string result = null;
            for( int i = 0; i < Count;i++ )
            {
                if (i > 0)
                {
                    result += ", ";
                }
                result += _arr[i].ToString();

            }
            return result;
        }
    }
}
