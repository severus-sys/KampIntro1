using System;

namespace Odev5Dictionary
{
    class Program
    {
        static void Main(string[] args) {

            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();

            myDictionary.Add(0, "Ali");
            myDictionary.Add(1, "Mehmet");
            myDictionary.Add(2, "Yusuf");
            myDictionary.Add(3, "Cenk");

            //Keys show
            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine("Id  : " + item);
            }

            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine("Name : " + item);
            }

        }
    }
}