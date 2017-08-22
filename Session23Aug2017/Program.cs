using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CollectionsStuff;
using ExplainingTypes;

namespace Session23Aug2017
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.ReadLine();
        }


        public void CollectionsStuffCode()
        {
            DynamicArray myarr = new DynamicArray();

            for (int i = 0; i < 12; i++)
            {
                myarr.AddElement(i);
            }
            myarr.Execute();

            LinkedListManager list = new LinkedListManager();

            for (int i = 0; i < 12; i++)
            {
                list.AddElement(i);
            }

            for (LinkedList i = list.GetRoot(); i != null; i = i.GetNext())
            {
                Console.WriteLine(i.GetElement());
            }

            DynamicArrayWithParamter<String> arr2 = new DynamicArrayWithParamter<string>();
            arr2.AddElement("Hello");

            List<Int32> cslist = new List<int>();
            cslist.Add(20);

            cslist.IndexOf(20);

            cslist.Remove(20);

            List<SomeClass> someClassList = new List<SomeClass>();
            someClassList.Add(new SomeClass());
        }

        public void ExplainingTypesCode()
        {
            ICoffeeMachine burgerKingCoffeeMachine = new BasicCoffeeMachine();
            
            burgerKingCoffeeMachine.AddCoffee();
            burgerKingCoffeeMachine.AddMilk();

            burgerKingCoffeeMachine = new McDonaldsCoffeeMachine();

            // burgerKingCoffeeMachine.AddWater() // Error;

            
        }
    }
}
