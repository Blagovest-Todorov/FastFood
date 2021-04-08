using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] quanOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(quanOrders);
            int biggestOrder = 0;
            int countToServe = orders.Count;

            while (orders.Count > 0)
            {
                //if (quantityFood <= 0)
                //{
                //    break;
                //}

                int currOrder = orders.Peek();

                if (quantityFood - currOrder >= 0)
                {
                    quantityFood -= currOrder;
                    orders.Dequeue();
                    countToServe -= 1;
                }
                else if (quantityFood - currOrder < 0)
                {
                    break;
                }                

                if (currOrder > biggestOrder)
                {
                    biggestOrder = currOrder;
                }
            }
            
            Console.WriteLine(quanOrders.Max());            

            if (countToServe == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else if ((countToServe != 0))
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", orders));
            }
        }
    }
}
