using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5Dictionary
{


    // T is type
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            Console.WriteLine("Constructor....");
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            // we should create temporarys for keys and values
            TKey[] tempkeys = keys;
            TValue[] tempvalue = values;


            //add 1 slot for  the array to keys 
            keys = new TKey[keys.Length+1];
            values = new TValue[values.Length+1];

            //should for loop in all values
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
            }

            for (int i = 0;i < tempvalue.Length; i++)
            {
                values[i] = tempvalue[i];

            }

            // last slot in array = lenght-1
            // 
            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;

        }

        //Show Key values
        
        public TKey[] Keys
        { 
            get { return keys; } 
        
        }

        public TValue[] Values
        {
            get { return values; }
        }

    }
}
