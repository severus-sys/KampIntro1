using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //T is type 
    class MyList<T>
    {
        T[] items;

        //constructor classı newlersek otomatik çalışıyor
        public MyList()
        {
            items  = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            // parametre olan item' i items e ekliyoruz
            //      son eleman 
            items[items.Length-1] = item;
        }

    }
}
