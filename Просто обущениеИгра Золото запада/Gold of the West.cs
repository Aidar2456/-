using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Просто_обущениеИгра_Золото_запада
{
    class Program
    {
        static void Main(string[] args)
        {
            Random chest = new Random();
            int number = chest.Next(4);
            int attempt = 3;
            Console.WriteLine("Игра Золото Запада");
            Console.WriteLine("Попробуй угадать в каком из сундуков лежит золото.\nЯ спрятал золото в одном из 4-ёх сундуках.\nУ тебя ровно 3 попытки чтобы угадать в каком из сундуков лежит золото.");

            do
            {
                int variable =
                Convert.ToInt32(Console.ReadLine());
                if (variable == number)
                {
                    Console.WriteLine(" Поздравляем. Вы вы получили вознаграждение.");
                    Console.WriteLine("Вы получили: 5 гр. золота.");
                    Console.ReadKey();
                    break;
                }
                else if (variable < 1 | variable > 4)
                    Console.WriteLine("Золото лежит в 1-ом из 4-ёх сундуках");

                else if (variable > number && (variable >= 1 && variable <= 4))
                {
                    attempt = attempt - 1;
                    Console.WriteLine("В этом сундуке пусто." + variable);
                    Console.WriteLine("У тебя осталось." + attempt + "попытки");
                }
                else if (variable < number && (variable >= 1 && variable <= 4))
                {
                    attempt = attempt - 1;
                    Console.WriteLine("В этом сундуке пусто." + variable);
                    Console.WriteLine("У тебя осталось." + attempt + "попытки");
                }
            }
            while (attempt > 0);
            if (attempt == 0)
                Console.WriteLine("Вы не смогли правильно ответить и проиграли.");
        Console.ReadKey();
        }
    }
}