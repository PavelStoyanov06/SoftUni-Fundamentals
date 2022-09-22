using System;
using System.Net.Http.Headers;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double heaadset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double expenses = 0;
            /*int keyboardTrash = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if(i % 2 == 0)
                {
                    expenses += heaadset;
                }
                if(i % 3 == 0)
                {
                    expenses += mouse;
                }
                if(i % 2 == 0 && i % 3 == 0)
                {
                    expenses += keyboard;
                    keyboardTrash ++;
                }
                if(keyboardTrash == 2)
                {
                    keyboardTrash = 0;
                    expenses += display;
                }
            }*/

            expenses += (lostGames / 2) * heaadset + (lostGames / 3) * mouse + (lostGames / 6) * keyboard + (lostGames / 12) * display;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
