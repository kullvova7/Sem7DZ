// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int m = ReadInt("Введите число: ");
    PrintNumbers(m);
}

void PrintNumbers(int number)
{
    if(number < 1) return;
Console.Write(number + " ");
    PrintNumbers(number - 1);
    
}
int ReadInt(String msg)
{
Console.WriteLine(msg);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
} 
Main();