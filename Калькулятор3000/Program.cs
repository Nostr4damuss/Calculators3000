// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");





{

    while (true)
    {
        int a = Convert.ToInt32(Console.ReadLine());



        switch (a)
        {
            case 1:
                {

                    Console.WriteLine("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(b + c);
                    break;
                }

            case 2:
                {
                    Console.WriteLine("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(b - c);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(b * c);
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());
                    while (c > 0)
                    {
                        Console.WriteLine(b / c);
                        break;
                    }
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Введите число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень, в которую хотите возвести число");
                    double N = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Math.Pow(b, N));
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Введите число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Math.Sqrt(b));
                    break;
                }

            case 7:
                {
                    Console.WriteLine("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите процент от числа, что Вам нужен");
                    double prots = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine((b / 100) * prots);
                    break;
                }

            case 8:
                {
                    Console.WriteLine("Введите число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    int factorial = 1;
                    for (int i = 2; i <= b; i++) // Вычисление факториала.
                    {
                        factorial *= i;
                    }

                    Console.WriteLine(factorial);
                    break;
                }

            case 9:

                {
                    Environment.Exit(0);
                }
                break;

        }
        Console.WriteLine("Повторите операцию ещё раз");
    }

}