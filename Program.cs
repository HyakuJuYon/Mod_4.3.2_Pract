using System;

namespace Mod_4._3._2_Pract
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            
            foreach(var item in array)

                {

                Console.Write(item + "");

                }


        }
    }
}
