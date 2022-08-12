// нужно написать программу для поиска максимума из 9 чисел, здесь алгоритм с функциями (в C# они именуются методами), но без массивов

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
// индексы:    0      1     2     3     4     5    6   7    8
int[] array = {1518, 2148, 3015, 941, 1528, 8614, 173, 18, 1976};
// array[0] = 12; -для поиска максимального элемента эта строка не нужна
// Console.WriteLine(array[4]); - для поиска максимального элемента эта строка тоже не нужна

int result = Max (
Max (array[0], array[1], array[2]),
Max (array[3], array[4], array[5]),
Max (array[6], array[7], array[8])
);
Console.WriteLine($"max number in this array is: {result}");

/* // этот код стираем, потому что вместо ввода каждой отдельной переменной с целым числом мы добавим массив.
int a1 = 13;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;
*/


/*
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.Write("Max number is: ", max);
*/ // эти строки кода пока не нужны