using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tìm giá trị trong mảng
            string[] game = new string[5];
            for (int i = 0; i < game.Length; i++)
            {
                Console.Write("Input a game: ");
                game[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("Enter a game: ");
            string input = Console.ReadLine();

            bool isExist = false;
            for (int i = 0;i < input.Length;i++)
            {
                if (game[i].Equals(input))
                {
                    Console.WriteLine("Position of the game in the list " + input + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if(!isExist)
            {
                Console.WriteLine("Not on this list");
            }
            Console.ReadKey();
        }
    }
}
