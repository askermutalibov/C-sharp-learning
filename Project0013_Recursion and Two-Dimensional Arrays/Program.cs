﻿/* Разбираем двумерные массивы

// string[,] table = new string[2, 3];  это форма записи двумерного строкового массива - инициализация с запятой [,] и указание размерности массива по строкам (2 строки) и по столбцам (3 столбца)

int[,] matrix = new int[5, 8]; // форма записи матрицы с 5 строками чисел и 8 столбцами чисел

string[,] table = new string[2, 5];

/*

этот массив содержит 2 строки, 5 столбцов и выглядит так:

table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]

а с учётом того, что это string, его можно представить так:

в  лесу  родилась  ёлочка  в
лесу  она  росла  зимой  и 

// String.Empty - а это инициализация строк

table[1, 2] = "слово"; // обращаемся к элементу массива, расположенном в 1 строке 2 столбца

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"--{table[rows, columns]}--");
    }
}

*/


/* выводим на экран массив, заполненный рандомными числами от 1 до 9
void PrintDimensionalArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // внешний цикл по i щёлкает столбцы. GetLength возвращает длину столбцов (3 столбца в этом массиве), ему присвоили 0
    {
        for (int j = 0; j < matr.GetLength(1); j++) // внутренний цикл по j щёлкает строки
        {
            Console.Write($"{matr[i, j]} "); // вывод строки
        }
        Console.WriteLine(); // новая строка перед выводом столбцов массива
    }
}

void FillDimensionalArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10)]
        }
    }
}

int[,] matrix = new int[3, 4];
PrintDimensionalArray(matrix);
FillDimensionalArray(matrix); Console.WriteLine();
PrintDimensionalArray(matrix);

/* 
DimensionalArray.GetLength(0) возвращает количество строк двумерного массива

DimensionalArray.GetLength(1) возвращает количество столбцов двумерного массива
*/

/* Необходимо представить на экране чёрно-белое изображение и закрасить внутреннюю область

// int[,] picture = new int[23, 25]; // 0 - условное обозначение незакрашенного пикселя; 1 - условное обозначение закрашенного пикселя

int[,] picture = new int[,] // 25 строк и 23 столбца
{ // 60 строка
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 61 строка
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 62
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 63
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 64    
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 65
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 66
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 67
    { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 68
    { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 69
    { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, // 70
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, // 71
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, // 72
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, // 73
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, // 74
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, // 75
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, // 76
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, // 77
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, // 78
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, // 79
    { 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, // 80
    { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, // 81
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, // 82
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 83
}; // 84 строка

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

void PaintImage(int row, int col)
{
    if (picture[row, col] == 0)
    {
        picture[row, col] = 1;
        PaintImage(row - 1, col);
        PaintImage(row, col - 1);
        PaintImage(row + 1, col);
        PaintImage(row, col + 1);
    }
}

PrintImage(picture);
PaintImage(13, 13); // случайная точка внутри изображения
PrintImage(picture);

*/

/*  Этому алгоритму нужно много ресурсов, поэтому на объёмных задачах могут быть проблемы   */


/* 
цикл проверки условий реализуем так:

if (точка сверху не закрашена) закрасить точку сверху
else if (точка сверху закрашена) проверь точку слева

if (точка слева не закрашена) закрасить точку слева
else if (точка слева закрашена) проверь точку слева

if (точка снизу не закрашена) закрасить точку снизу
else if (точка снизу закрашена) проверь точку справа

if (точка справа не закрашена) закрасить точку справа
else if (точка справа закрашена) проверь точку сверху

если изначальная позиция исполнителя алгоритма находится в точке (x, y), то вот как будут выглядеть команды для движения по другим направлениям:
(x - 1, y) - движение вверх на 1 строку
(x + 1, y) - движение вниз на 1 строку
(x, y + 1) - движение вправо на 1 столбец
(x, y - 1) - движение влево на 1 строку
(x - 1, y + 1) - движение по диагонали вверх на 1 строку и вправо на 1 столбец соответственно
(x - 1, y - 1) - движение по диагонали вверх на 1 строку и влево на 1 столбец соответственно
(x + 1, y - 1) - движение по диагонали вниз на 1 строку и влево на 1 столбец соответственно
(x + 1, y + 1) - движение по диагонали вниз на 1 строку и вправо на 1 столбец соответственно

всё это мы благополучно добавили внутрь метода void PaintImage(int row, int col) [заодно реализовали рекурсию]

*/

/* Вычислим факториал с помощью рекурсии
(пример: 6! = 6 * 5 * 4 * 3 * 2 * 1   |   6! = 6 * 5!   |   6! = 6 * 5 * 4!)

double Factorial(int n)
{
    if (n == 0 || n == 1) return 1; // 0! = 1! = 1
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 56; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // факториал числа 17 переполняет тип "integer", решаем через смену типа с int на double
}

Console.WriteLine($"Факториал указанного числа равен {Factorial(56)}"); // запись 55! = 1,2696403353658276E+73 означает, что для полной записи числа получившийся результат нужно умножить на 10 в 73 степени

*/

/* Теперь разберём числа Фибоначчи 

f(1) = 1;
f(2) = 1;
f(n) = f(n - 1) + f(n - 2);

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 34; i++) // если вводить больше 34, то вывод чисел в консоль очень сильно замедляется, вплоть до 20 секунд на вывод одного числа из последовательности Фибоначчи
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

*/

/* 
Рекурсия также применяется для обхода директории, "захода в директорию", обхода всех директорий внутри или даже сыграть в тетрис с применением рекурсии
*/