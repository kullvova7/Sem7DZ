// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Main()
{
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
    
    if (m <= n)
    {
        Console.WriteLine($"Числа от {m} до {n}:");
        PrintNumbers(m, n);
    }
    else
    {
        Console.WriteLine("Введитеж: m <= n.");
    }
}
void PrintNumbers(int first, int end)
{
    if (first <= end)
    {
        Console.Write($"{first} ");
        PrintNumbers(first + 1, end);
    }
}
Main();