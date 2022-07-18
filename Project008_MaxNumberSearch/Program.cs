// нужно написать программу для поиска максимума из 9 чисел, используя функции и массивы

/* // этот алгоритм "стихийный", без функций, ниже будет с функциями.

int a1 = 13;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311; // изначально ввели 23, для тестирования вводим 2311. Всё работает, вывод числа 313 как максимального.
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313; // изначально ввели 33, для тестирования вводим 313. Всё работает, вывод числа 313 как максимального.

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max); // эта версия кода работает с изначально введёнными данными, в которых из 9 переменных один максимум.
// такой подход решения задачи назван "стихийным", следующий подход будет с использованием функций.

*/
// теперь напишем код с функциями

int arg1;
int arg2;
int arg3;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 13;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.Write("Max number is: ", max);

/* // это нерабочая версия алгоритма поиска максимума из 9 чисел, которую я придумал сам после вывода системной ошибки из неверного алгоритма, списанного со 2 лекции по C#.
int FirstNumber = 13;
int SecondNumber = 21;
int ThirdNumber = 39;
int FourthNumber = 12;
int FifthNumber = 2311;
int SixthNumber = 33;
int SeventhNumber = 12;
int EightthNumber = 23;
int NinthNumber = 313;

int arg1 = Math.Max (FirstNumber, SecondNumber);
int arg2 = Math.Max (SecondNumber, ThirdNumber);
int arg3 = Math.Max (ThirdNumber, FourthNumber);
int arg4 = Math.Max (FourthNumber, FifthNumber);
int arg5 = Math.Max (FifthNumber, SixthNumber);
int arg6 = Math.Max (SixthNumber, SeventhNumber);
int arg7 = Math.Max (SeventhNumber, EightthNumber);
int arg8 = Math.Max (EightthNumber, NinthNumber);

int result = arg1;
int MaxNumber;

{
    if (result >= arg2)
    {
        result = arg2;
        MaxNumber = arg2;
    }  
    else
    {
        result = arg1;
        MaxNumber = arg1;
    }

    if (arg3 >= result & arg3 >= MaxNumber)
    {
        result = arg3;
        MaxNumber = arg3;
    }
    else
    {
        result = arg2;
        MaxNumber = arg2;
    }

    if (arg4 >= result & arg4 >= MaxNumber)
    {
        result = arg4;
        MaxNumber = arg4;
    }
    else
    {
        result = arg2;
        MaxNumber = arg2;
    }
    if (arg5 >= result & arg5 >= MaxNumber)
    {
        result = arg5;
        MaxNumber = arg5;
    }
    else
    {
        result = arg2;
        MaxNumber = arg2;
    }

    if (arg6 >= result & arg6 >= MaxNumber)
    {
        result = arg6;
        MaxNumber = arg6;
    }
    else
    {
        result = arg2;
        MaxNumber = arg2;
    }
    if (arg7 >= result & arg7 >= MaxNumber)
    {
        result = arg7;
        MaxNumber = arg7;
    }
    else
    {
        result = arg2;
        MaxNumber = arg2;
    }
    if (arg8 >= result & arg8 >= MaxNumber)
    {
        result = arg8;
        MaxNumber = arg8;
    }
    else
    {
        result = arg2;
        MaxNumber = arg2;
    }
}
Console.Write("result is: "); Console.Write(result);
return result;
/*

/*
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
*/
/*
if (SecondNumber > max) max = SecondNumber;
if (ThirdNumber > max) max = ThirdNumber;
if (FourthNumber > max) max = FourthNumber;
if (FifthNumber > max) max = FifthNumber;
if (SixthNumber > max) max = SixthNumber;
if (SeventhNumber > max) max = SeventhNumber;
if (EigtthNumber > max) max = EigtthNumber;
if (NinthNumber > max) max = NinthNumber;
*/ // заменили эти строки кода строками с 4 по 9, где сравнивали аргументы (самая первая версия кода)