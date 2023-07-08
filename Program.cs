using System;

class Program
{
    //перевірка чи можна побудувати квадрат
    static bool IsSquare(double y1, double y2, double y3, double y4, double x1, double x2, double x3, double x4)
    {
        double side1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        double side2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
        double side3 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
        double side4 = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));

        double diagonal1 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        double diagonal2 = Math.Sqrt(Math.Pow(x2 - x4, 2) + Math.Pow(y2 - y4, 2));

        if (side1 == side2 && side2 == side3 && side3 == side4 &&
            diagonal1 == diagonal2)
        {
            return true;
        }

        return false;
    }

    static void Main()
    {

        double y, y1, y2, y3, y4, x, x1, x2, x3, x4;

        while (true)
        {
            Console.WriteLine("Введіть координати точок квадрата");
            Console.WriteLine();

            Console.Write("Введіть значення для лівої нижньої точки: ");
            string[] input1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(input1[0]);
            y1 = double.Parse(input1[1]);

            Console.Write("Введіть значення для лівої верхньої точки: ");
            string[] input2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(input2[0]);
            y2 = double.Parse(input2[1]);

            Console.Write("Введіть значення для правої верхньої точки: ");
            string[] input3 = Console.ReadLine().Split(' ');
            x3 = double.Parse(input3[0]);
            y3 = double.Parse(input3[1]);

            Console.Write("Введіть значення для правої нижньої точки: ");
            string[] input4 = Console.ReadLine().Split(' ');
            x4 = double.Parse(input4[0]);
            y4 = double.Parse(input4[1]);


            if (IsSquare(y1, y2, y3, y4, x1, x2, x3, x4))
            {
                Console.Write("Введіть координати точки: ");
                string[] input5 = Console.ReadLine().Split(' ');
                x = double.Parse(input5[0]);
                y = double.Parse(input5[1]);
                if (x >= x1 && x <= x3 && y >= y1 && y <= y2) //перевірка чи точка надежить квадрату
                {
                    Console.WriteLine("Точка належить квадрату.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Точка не належить квадрату.");
                    Console.ReadKey();

                }
                break;
            }
            else
            {
                Console.WriteLine("Неможливо побудувати квадрат за введеними точками.");
                Console.WriteLine("Введіть '1' для повторного вводу або будь-що інше для виходу:");
                string choice = Console.ReadLine();

                if (choice == "1")
                    continue;
                else
                    break;
            }
        }
    }
}


//приклад введення
/*
 
0 0
0 5
5 5
5 0
2 3

*/