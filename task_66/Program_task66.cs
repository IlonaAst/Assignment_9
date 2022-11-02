/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите два натуральных числа N и M");
Console.ResetColor();
Console.WriteLine("Введите большее число N");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите меньшее число M");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int printRange(int N)
{
    if (N == (userNumber2)-1)
    {
        return 0;
    }
    return (N) + printRange(N-1);
}
int sum = printRange(userNumber);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Сумма чисел от M до N = {sum}");
Console.ResetColor();

