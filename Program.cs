using System;

namespace BalagwisJohnDenverWhileLoop
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\n====================================================================================================\n");
                Console.WriteLine("HI! WELCOME ! THERE'S A LOT OF FOOD HERE FOR YOU, PLEASE ENTER THE NUMBER OF THE FOOD THAT YOU WANT:");
                Console.WriteLine("\n====================================================================================================\n");
                Console.WriteLine("\t1] HOT-SI-LOG ");
                Console.WriteLine("\t2] LONG-SI-LOG ");
                Console.WriteLine("\t3] TO-SI-LOG ");
                Console.WriteLine("\t4] SAR-SI-LOG ");
                Console.WriteLine("\t5] EXIT ");
                Console.WriteLine("\n====================================================================================================\n");
                Console.Write("PLEASE ENTER YOUR ORDER # ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("\n====================================================================================================\n");
                    Console.WriteLine("YOU HAVE ORDERED: 1] HOT-SI-LOG - HOTDOG SINANGAG ITLOG");
                    Console.WriteLine("\nTHANK YOU FOR COMING!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n====================================================================================================\n");
                    Console.WriteLine("YOU HAVE ORDERED: 2] LONG-SI-LOG - LONGANISA SINANGAG ITLOG");
                    Console.WriteLine("\nTHANK YOU FOR COMING!");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n====================================================================================================\n");
                    Console.WriteLine("YOU HAVE ORDERED: 3] TO-SI-LOG - TOCINO SINANGAG ITLOG");
                    Console.WriteLine("\nTHANK YOU FOR COMING!");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\n====================================================================================================\n");
                    Console.WriteLine("YOU HAVE ORDERED: 4] SAR-SI-LOG - SARDINAS SINANGAG ITLOG");
                    Console.WriteLine("\nTHANK YOU FOR COMING!");
                }
                else if (choice == 5)
                {
                    Console.WriteLine("\n====================================================================================================\n");
                    Console.WriteLine("UWI NA KANA TOY, SA BAHAY NA LANG KUMAIN HAHA.");
                    Console.WriteLine("THANK YOU FOR USING THIS PROGRAM, GOOD BYE.");
                    break;
                }
                else
                {
                    Console.WriteLine("\n====================================================================================================\n");
                    Console.WriteLine("PLEASE ENTER A VALID INPUT.");
                }
            }
        }
    }
}