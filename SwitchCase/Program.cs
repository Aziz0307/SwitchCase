using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Ponedelnik");
                    break;
                case 2:
                    Console.WriteLine("Vtornik");
                    break;
                case 3:
                    Console.WriteLine("Sreda");
                    break;
                case 4:
                    Console.WriteLine("Chetverg");
                    break;
                case 5:
                    Console.WriteLine("Pyatnitsa");
                    break;
                case 6:  
                    Console.WriteLine("Subbota");
                    break;
                case 7:
                    Console.WriteLine("Voskresenie");
                    break;
                default: Console.WriteLine("Please insert a number from 1 to 7");
                    break;
            }
        }
    }
}