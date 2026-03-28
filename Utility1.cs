using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Assignmentadv
{
    internal class Utility1
    {
        public static void PrintArray<T>(T[] items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static T FindMax<T>(T[] items) where T : INumber<T>
        {
            T max = items[0];
            foreach (var item in items)
            {
                if (item  >  max ) 
                {
                    max = item;
                }
               
                
                
            }
            return max;
        }
        
         
    }
}
