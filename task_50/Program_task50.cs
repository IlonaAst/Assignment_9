/*
Задача 50: Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
int[,] generateArray(int height, int width, int deviation) // Функция для генерации матрицы (1) случайных чисел
{
    int[,] generatedArray = new int[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i,j] = new Random().Next(-deviation, deviation+1);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
int[,] generateArrayOfIndices(int[,] inputArray) // Функция для генерации матрицы (2) индексов от 0 по порядку
{
    int[,] ArrayOfIndices = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            ArrayOfIndices [i,j] = i*inputArray.GetLength(1) + j;
        }
    }
    return ArrayOfIndices;        
} 
int[,] generatedArray = generateArray(4,5,100); // Вывод матриц (1) и (2) в консоль
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Исходная матрица чисел");
showArray(generatedArray);
int[,] generatedArrayOfIndices = generateArrayOfIndices(generatedArray);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Матрица индексов");
showArray(generatedArrayOfIndices);

// Функция для поиска числа в матрице (1) по его индексу в матрице (2)
int getNumber (int[,] generatedArray, int[,] generatedArrayOfIndices, int Index) 
{ 
    int number = 1000;
    for (int i = 0; i < generatedArray.GetLength(0); i++)
    {
        for (int j = 0; j < generatedArray.GetLength(1); j++)
        {
            if (Index == generatedArrayOfIndices[i,j])
            {
                number = generatedArray[i,j];
            }
        }
    }
    return number;    
} 

int userIndex = 0;
Console.WriteLine("Введите индекс числа в матрице");
userIndex = Convert.ToInt32(Console.ReadLine());

int num = getNumber(generatedArray, generatedArrayOfIndices, userIndex);
if (num !=1000)
{
    Console.WriteLine($"Индексу {userIndex} соответствует число {num} в матрице");
}
else
{
    Console.WriteLine($"Число с индексом {userIndex} не найдено в матрице");
}


/* Пример вывода:
Исходная матрица чисел
         0       1       2       3      4  
0       -64      62     -94      20     33 
1        84     -15      28     -51     8  
2       -75     -82     -32     -72    -17
3       -14      0      -36      75     99
Матрица индексов
        0        1      2       3       4
0       0        1      2       3       4
1       5        6      7       8       9
2       10      11      12      13      14
3       15      16      17      18      19
Введите индекс числа в матрице
16
Индексу 16 соответствует число 0 в матрице
*/
