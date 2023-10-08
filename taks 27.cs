// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        
        int sum = CalculateDigitSum(input);
        
        Console.WriteLine($"Сумма цифр в числе {input} равна {sum}");
    }
    
    static int CalculateDigitSum(string input)
    {
        int sum = 0;
        foreach (char digitChar in input)
        {
            if (char.IsDigit(digitChar))
            {
                int digit = (int)char.GetNumericValue(digitChar);
                sum += digit;
            }
        }
        return sum;
    }
}