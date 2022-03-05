using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = ("Salam AzTU");
            bool p205 = true;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i]=='a') 
                {
                    Console.WriteLine("a-simvolu var");
                    p205 = false;
                    break;
                }
            }
            if (p205)
            {
                    Console.WriteLine("a-simvolu tapilmadi");
            }
            
        }
    }
}
