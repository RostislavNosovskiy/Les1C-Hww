namespace Lesson1Hw;
// Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b,
// введенные из командной строки, и выводящую результат выполнения на экран.

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 3)
        {
            if (int.TryParse(args[0], out int num1) && int.TryParse(args[2], out int num2))
            {
                string operetion = args[1];
                int operetionRes = 0;
                switch (operetion)
                {
                    case "+":
                        operetionRes = num1 + num2;
                        Console.WriteLine($"{num1} {operetion} {num2} = {operetionRes} ");
                        break;
                    case "-":
                        operetionRes = num1 - num2;
                        Console.WriteLine($"{num1} {operetion} {num2} = {operetionRes} ");
                        break;
                    case "*":
                        operetionRes = num1 * num2;
                        Console.WriteLine($"{num1} {operetion} {num2} = {operetionRes} ");
                        break;
                    case "/":
                        operetionRes = num1 / num2;
                        Console.WriteLine($"{num1} {operetion} {num2} = {operetionRes} ");
                        break;
                    default:
                        Console.WriteLine("Неопределённое арифметическое действие");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Неправильный формат числа");
            }
        }
        else
        {
            Console.WriteLine("Неправильный формат выражения, введите выражения вида: 'a арифметическое дейтвие b' ");
        }
    }
}
