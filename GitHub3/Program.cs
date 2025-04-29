// See https://aka.ms/new-console-template for more information

{
    double A = 0;
    double B = 0;
    bool exit = false;

    while (!exit)
    {

        Console.WriteLine("Меню:");
        Console.WriteLine("1. Ввести A");
        Console.WriteLine("2. Ввести B");
        Console.WriteLine("3. Выполнить операцию '+'");
        Console.WriteLine("4. Выполнить операцию '-'");
        Console.WriteLine("5. Выполнить операцию '*'");
        Console.WriteLine("6. Выполнить операцию '/'");
        Console.WriteLine("7. Выход");
        Console.Write("Выберите пункт меню: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Введите значение A: ");
                A = Convert.ToDouble(Console.ReadLine());
                break;

            case "2":
                Console.Write("Введите значение B: ");
                B = Convert.ToDouble(Console.ReadLine());
                break;

            case "3":
                Console.WriteLine($"Результат A + B = {A + B}");
                break;

            case "4":
                Console.WriteLine($"Результат A - B = {A - B}");
                break;

            case "5":
                Console.WriteLine($"Результат A * B = {A * B}");
                break;

            case "6":
                if (B != 0)
                {
                    Console.WriteLine($"Результат A / B = {A / B}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                break;

            case "7":
                exit = true;
                break;

            default:
                Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте еще раз.");
                break;
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
        Console.ReadKey();
    }
}
