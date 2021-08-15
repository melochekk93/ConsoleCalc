using System;

namespace Калькулятор1
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            double numb1=0;
            double numb2=0;
            string operation;
            while (again == 'y')
            {
                try
                {
                    Console.WriteLine("Введите число 1: ");
                    numb1 = double.Parse(Console.ReadLine());
                    
                   

                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Ошибка! Попробуйте ввести число!");
                    continue;
                }
            n2:
                try
                {
                    
                    Console.WriteLine("Введите число 2: ");
                    numb2 = double.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка! Попробуйте ввести число!"); goto n2;
                  //  continue;
                }
            op:
                Console.WriteLine("Выберите операцию: '+', '-', '/', '*', '^' ");
            
                operation = Console.ReadLine();
                
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(numb1 + numb2);
                        break;
                    case "-":
                        Console.WriteLine(numb1 - numb2);
                        break;
                    case "*":
                        Console.WriteLine(numb1 * numb2);
                        break;
                    case "/":
                        if (numb2 != 0)
                        {
                            Console.WriteLine(numb1 / numb2);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на ноль!");
                        }
                        break;
                    case "^":
                        Console.WriteLine(Math.Pow( numb1,  numb2));
                        break;
                    default:
                        Console.WriteLine("Ошибка!Недопустимая операция!");
                        goto op;
                        break;
                }
                Console.WriteLine("Хотите продолжить? 'y' - продолжить, 'n' - выйти");
                again = Convert.ToChar( Console.ReadLine());
            }
        }
    }
}
