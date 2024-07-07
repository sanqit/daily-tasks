namespace DailyTasks.Tasks;

public class Task1
{
    public static void Run()
    {
        Console.WriteLine("Введите число, программа проверит является ли число четно красивым");

        var input = Console.ReadLine()!;

        string? resultMessage = default;
        foreach (var inputChar in input)
        {
            if (!char.IsDigit(inputChar))
            {
                resultMessage = "Не является числом";
                break;
            }

            var digit = inputChar - '0';

            if (digit % 2 != 0)
            {
                resultMessage = "Число не является четнокрасивым";
                break;
            }
        }

        resultMessage ??= "Число является четно красивым";

        Console.WriteLine(resultMessage);
    }
}