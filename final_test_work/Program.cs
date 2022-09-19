
Console.Clear();

void PrintArrayDefault(string[] defautArray)
{
    int count = 0;
    Console.WriteLine("Массив строк -> Массив строк длина которых меньше либо равна 3-ём символа");
    for (int i = 0; i < defautArray.Length; i++)
    {
        Console.Write($"{defautArray[i]}, ");
    }

    Console.Write("\b");
    Console.Write("\b");
    Console.Write(" -> ");

    for (int j = 0; j < defautArray.Length; j++)
    {
        if (defautArray[j].Length <= 3)
        {
            Console.Write($"{defautArray[j]}, ");
        }

        else
        {
            count++;
        }
    }

    Console.Write("\b");
    Console.Write("\b");
    Console.Write(" ");

    if (count == defautArray.Length)
    {
        Console.Write("[]");
    }

    Console.WriteLine();
}

void CreationArray(string[] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите слово и нажмите 'Enter': ");
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    int count = 0;

    Console.WriteLine();
    Console.WriteLine("Массив строк -> Массив строк длина которых меньше либо равна 3-ём символа");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.Write("\b");
    Console.Write("\b");
    Console.Write($" -> ");

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            Console.Write($"{array[j]}, ");
        }

        else
        {
            count++;
        }
    }

    Console.Write("\b");
    Console.Write("\b");
    Console.Write(" ");

    if (count == array.Length)
    {
        Console.Write("[]");
    }

    Console.WriteLine();
}

Console.WriteLine($"Здраствуйте, Вы будите создавать свой массив или воспользуютесь массивом по умолчанию?");
Console.WriteLine($"Для того чтобы создать свой массив, нажмите клавишу 'y'");
Console.WriteLine($"Для того чтобы воспользоваться массивом по умолчанию нажмите клавишу 'n'");
Console.Write($"Что Вы выберете: ");

string button = Console.ReadLine()!;

Console.WriteLine();

if (button.ToLower() == "y")
{
    Console.WriteLine("Создаем свой массив");
    Console.Write("Введите количество строк которых Вы хотите добавить в новый массив: ");

    int numberOfLines = int.Parse(Console.ReadLine()!);

    string[] array = new string[numberOfLines];

    CreationArray(array);
    PrintArray(array);
}

if (button.ToLower() == "n")
{
    string[] defautArray = new string[] { "asfg", "jkl7a", "a", "220", "we" };

    PrintArrayDefault(defautArray);
}

if (button.ToLower() != "y" && button.ToLower() != "n")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Что-то пошло не так поробуйте запустить программу еще раз!");
}