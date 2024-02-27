// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

void Main()

{
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
    
    int result = AckFunc(m, n);

    Console.WriteLine($"Значение для m = {m} и n = {n}: {result}");
}
int AckFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckFunc(m - 1, 1);
    }
    else
    {
        return AckFunc(m - 1, AckFunc(m, n - 1));
    }
}
Main();