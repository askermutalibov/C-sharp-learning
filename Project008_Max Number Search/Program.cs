// нужно написать программу для поиска максимума из 9 чисел, здесь алгоритм с функциями (в C# они именуются методами), но без массивов

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

int arg1; // вводим аргументы функции для метода Max
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

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.Write("Max number is: ");
Console.Write(max);