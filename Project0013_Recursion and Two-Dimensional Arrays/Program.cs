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



/* 6-й семинар по C#. Теперь разберём двумерные массивы и рекурсию на конкретных задачах из ejudge (учисьдома)

// Задача 001.
Дана таблица чисел, состоящая из N строк по M чисел в каждой. Все числа в таблице - натуральные, не превышающие 1 000. Требуется найти наименьшее число в этой таблице.

Во входном файле записано сначала число N - количество строк, затем число M - количество столбцов таблицы (100 >= N >= 1, 100 >= M >= 1)
Далее идёт сама таблица.


*/

/* Задача 2 - создать массив целых чисел N x M и заполнить его случайными числами от 1 до 10.

int N = 5; // строк
int M = 4; // столбцов
int[,] a; // описывание массива
a = new int[N, M]; // создание массива

// инициализация случайными числами
Random random = new Random();

for (int i = 0; i < a.GetLength(0); i++) // вместо for (int j = 0; j < M; j++)
{
    for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
    {
        a[i, j] = random.Next(1, 11);
    }
}

// вывод массива на экран

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
    {
        System.Console.Write($"{a[i, j]}  ");
    }
    System.Console.WriteLine();
}

*/

/* 7 семинар по C#: продолжаем разбирать рекурсию 

Обязательное условие при определении рекурсии - описание условия выхода
*/

// Переходим к решению задач

// Сбор строки с числами от a до b, a <= b.

/* процедурно это выглядит так: 

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i < b; i++)
    {
        result += $" {i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

*/

/* рекурсивно это выглядит так: 

string NumbersRecursion(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRecursion(a + 1, b); // если нужно будет вывести числа в порядке убывания, то нужно будет заменить порядок NumbersRecursion и вывод $"{a} "
    else return String.Empty;
}

Console.WriteLine(NumbersRecursion(1, 10));

*/

// Вывести сумму чисел от 1 до N

/* процедурно это выглядит так:

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;
}

*/

/* рекурсивно это выглядит так:
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

*/

// найти факториал числа

/* процедурно 

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(FactorialFor(5));

*/

/* рекурсивно 

int FactorialRec(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * FactorialRec (n - 1);
}

Console.WriteLine(FactorialRec(5));

*/

// Возвести целое число a в натуральную степень n.

/* процедурно выглядит так: 
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine(PowerFor(2, 8));

*/

/* рекурсивно выглядит так: 
int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    */
/* 2 строки в цикле выше можно заменить 1 строкой с помощью тернарных операторов:
return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}


Console.WriteLine(PowerRec(2, 8));

/* с использованием теории возведения в степень из математики, но также рекурсивно: 

int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 8));
*/

// Перебор слов. В некотором машинном алфавите имеются 4 буквы: "а", "и", "с", "в". Нужно показать все слова, состоящие из T букв, которые можно построить из букв этого алфавита.

/* итеративный подход: 

char[] Alphabet = { 'а', 'и', 'с', 'в' }; // Алфавит, помещённый в массив символов

int count = Alphabet.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5} {Alphabet[i]}{Alphabet[j]}{Alphabet[k]}{Alphabet[l]}{Alphabet[m]}"); // для пятибуквенных слов
                }
            }
        }
    }
}

*/

/* решим рекурсивно: 

int n = 1;

void FindWords(string alphabet, char[] word, int length = 0) // метод, принимающий "алфавит" - массив букв одной строкой, массив букв char[] word, на цикле рекурсии будет собираться длина слова length.
{
    if (length == word.Length) // если длина слова совпала с длиной массива букв, то на экран выводится этого слово
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++) // в противном случае (если условие выше, под if, не работает) запускаем цикл по всем элементам массива, для того, чтобы собрать очередное новое слово.
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]); // суть алгоритма - количество всех возможных слов из string alphabet букв, в каждом из которых word букв равно alphabet^word. Иными словами, при условии вывода на экран слов из 3 букв в каждом, но при заданных 4 буквах "аисв" количество всех возможных вариантов будет равно 4^3 = 64. При 4 буквах в каждом слове - 4^4 = 256

*/

/* сейчас посмотрим алгоритм обхода директории. Обход директорий - просмотр всех папок, находящихся внутри директории и все файлы, находящиеся внутри папок */

/*
string path = "D:/projects_main dir/C sharp lectures repo/Project003_Integers Summation";
DirectoryInfo dir = new DirectoryInfo(path);
Console.WriteLine(dir.CreationTime);
*/ // выводит на экран дату и время создания этой конкретной папки

/*
string path = "D:/projects_main dir/C sharp lectures repo/Project003_Integers Summation";
DirectoryInfo dir = new DirectoryInfo(path);
// Console.WriteLine(dir.GetFiles());
FileInfo[] fi = dir.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/ // массив FileInfo[] fi содержит все файлы директории, в него записываем команду GetFiles из директории, указанной в path и по циклу for возвращаем имя каждого файла в директории


/* теперь создадим рекурсивный алгоритм, который будет ходить по папкам и смотреть их содержимое. 

void CatalogInfo(string path, string indent = "") // метод, в качестве агрумента путь к текущей папке path и косвенный приём indent для отступов, чтобы видеть структуру папки.
{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем информацию о директории, в которую мы зашли по пути path

    DirectoryInfo[] catalogs = catalog.GetDirectories(); // массив всех файлов в директории (папке)
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // выводим имя папки, а затем рекурсивно заныриваем и получаем информацию о всех папках из массива всех файлов catalogs
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles(); // получим весь список текущих файлов текущей директории (каталога) после вывода элементов массива

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}"); // покажем все текущие файлы
    }
}

string path = "D:/projects_main dir/C sharp lectures repo";
CatalogInfo(path);

*/

/* игра в пирамидки (Ханойская башня) через рекурсию 

void HanoiTower(string with = "1", string on = "3", string some = "2", int count = 4) // with - рабочий шпиль, с него берём блины, on - итоговый шпиль, на нём должны оказаться все 3 (или больше) блина; some - промежуточный шпиль, count = количество блинов на исходном рабочем шпиле.
{
    if (count > 1) HanoiTower(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) HanoiTower( some, on, with, count - 1);
}

HanoiTower();
/* output:  (для башни из 3 блинов)
1 >> 3 // перемещаем с 1 на 3 шпиль
1 >> 2 // с 1 на 2 шпиль
3 >> 2 // и т.д.
1 >> 3
2 >> 1
2 >> 3
1 >> 3
*/ // 7 действий

/* output:  (для башни из 4 блинов)
1 >> 2
1 >> 3
2 >> 3
1 >> 2
3 >> 1
3 >> 2
1 >> 2
1 >> 3
2 >> 3
2 >> 1
3 >> 1
2 >> 3
1 >> 2
1 >> 3
2 >> 3
*/ // 15 действий

/* для башни из 5 блинов количество действий будет равным 31 */
/* для 6 блинов - 63 действия */
/* 7 блинов - 127 действий и т.п.*/



/* рекурсия для обхода разных структур 

для примера - простейшее арифметическое выражение может быть преобразовано в дерево через теорию графов:

((4 - 2) * (1 + 3)) / 10

преобразуется в граф связанных деревьев такого вида (с нумерацией элементов справа):

                /      [1-я]
             * [2-я] 10 [3-я]
  - [4-я]  + [5-я]
4 [8-я] 2 [9-я]   1 [10-я] 3 [11-я]

объекты выше - родительские по отношению к тем, что ниже и наоборот - то, что ниже - дочернее по отношению к тому, что выше

общее правило:
                ai
            a2i     a(2i + 1)
на кругах (объектах) из примера выше, эта закономерность аналогично соблюдается: родительский элемент a4 несёт с собой дочерние элементы a8 слева и a9 справа
*/


/* реализуем алгоритмом: 

string empty = String.Empty;
string[] tree = { empty, "/", "*", "10", "-", "+", empty, empty, "4", "2", "1", "3" }; // задача обхода дерева заключается в получении всех узлов, которые в этом дереве содержатся.

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos; // считаем позицию левого дочернего поддерева (для / это *)
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если левое дерево имеется и тот элемент, хранящийся там, не является пустым, то нужно рекурсивно запустить обход этого дерева с текущей позиции
        System.Console.WriteLine(tree[pos]); // выводим на экран узел (значение конкретной операции/числа)
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // аналогично для правого
    }
}
InOrderTraversal();
*/

/* output:
4
-
2
*
1
+
3
/
10
*/ // то же самое выражение, которое было в начале разобрано на узлы дерева

/* для справки: 
HTML-код разметки сайта - тоже хороший пример дерева
JSON
XML - туда же
Разбор выражений
Анализ текста (применяются графические редакторы, семантические редакторы)
Обходы графов
Обходы деревьев - общая тема с подтемами выше
и т.д.
*/

/* недостаток рекурсии - время работы, сейчас убедимся в этом на примере:

decimal fRec = 0; // используется в рекурсивной версии алгоритма
decimal fIte = 0; // считает количество итераций цикла

decimal FibonacciRecursively(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursively(n - 1) + FibonacciRecursively(n - 2);
}

decimal FibonacciIteratively(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

/// ожидаем увидеть:
// 1 2 3 4 5 6 (итерации)
// 1 1 2 3 5 8 (результат Фибоначчи)

Console.ReadLine(); // press any key для запуска итеративного алгоритма
DateTime datetimeIteratively = DateTime.Now; // вводим datetimes для того, чтобы сравнить скорость работы итеративного алгоритма с рекурсивным алгоритмом
for (int n = 1; n < 38; n++)
{
    Console.WriteLine($"({n}) число Фибоначчи = {FibonacciIteratively(n)};  fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}

Console.WriteLine((DateTime.Now - datetimeIteratively).TotalMilliseconds);
Console.WriteLine();
Console.ReadLine(); // press any key для запуска рекурсивного алгоритма
DateTime datetimeRecursively = DateTime.Now;
for (int n = 1; n < 38; n++)
{
    Console.WriteLine($"({n}) число Фибоначчи = {FibonacciRecursively(n)};  fRec = {fRec.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - datetimeRecursively).TotalMilliseconds);

/* сравнение скорости работы алгоритмов:
вывод результатов итеративного алгоритма:

FibonacciIteratively(10) = 89 fIte =   10 // 10 вызовов метода для вывода 10 числа Фибоначчи
FibonacciIteratively(11) = 144 fIte =   11
...
FibonacciIteratively(28) = 514229 fIte =   28 // 28 вызовов метода
FibonacciIteratively(29) = 832040 fIte =   29

вывод результатов рекурсивного алгоритма:

FibonacciRecursively(10) = 89 fRec =   177 // 177 вызовов метода для вывода 10 числа Фибоначчи
FibonacciRecursively(11) = 144 fRec =   464
...
FibonacciRecursively(28) = 514229 fRec = 2 692 231
FibonacciRecursively(29) = 832040 fRec = 4 356 310 // 4.5 млн. вызовов метода для вывода 29 числа Фибоначчи.

сравнение по разнице между DateTime.Now и datetimes по каждому циклу:

первые 37 чисел Фибоначчи в ИТЕРАТИВНОМ алгоритме высчитываются за 95,57 миллисекунд = 0,096 секунд
первые 37 чисел Фибоначчи в РЕКУРСИВНОМ алгоритме высчитываются за 24 910,14 миллисекунд = 24,91 секунд.
В этом конкретном случае РЕКУРСИВНЫЙ алгоритм работает медленнее итеративного в 259 раз, это существенная разница.

*/




/* 9 семинар по C#: переходим от простого к практике 

// https://sharplab.io/

// https://visualstudio.microsoft.com/ru/vs/community/ - для установки Visual Studio Community Edition (Сергей рекомендует версию Community, она бесплатная)

// ASP.NET при установке Visual Studio пригодится для веб-разработки
Самое важное расширение - Кроссплатформенная разработка для .NET

При нажатии клавиши F12 при наведении на один из объектов (например, объект Console) в выпадающем окне появится описание этого объекта с содержанием его подобъектов

в предыдущих версиях C# перед написанием кода нужно было добавлять using System; , using System.Linq; и т.д.

В общем случае структура типичной программы, написанной на C# версии до 10.0 выглядит так:

namespace ConsoleVisualStudio
{

    class Program
    {
        staic public void Main(string[] args) // в этом методе выполняется код, шаблон string[] args добавляется, если будут нужны аргументы
        {
            Console.WriteLine("Hello, World!")
            Console.ReadKey(); // добавляем эту команду для стабильного запуска программы HelloVisualStudio.cs из проводника без танцев с бубном со сменой директории в командной строке Windows.
        }
    } // на Windows версии позже 10 это спокойно запустится, на предыдущих версиях могут быть проблемы, поскольку .NET работает со своим окружением - виртуальной машиной, которая называется CLR - Common Language Runtime.
}

*/


/* Разберём 64 задачу из списка задач для практики C#: 
// Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника */

int row = 5;
int[,] triangle = new int[row, row];
const int cellWidth = 4; // количество символов для вывода этого треугольника

void FillPascalTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, 1] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; // сумма текущего элемента в треугольнике Паскаля равна сумме элемента, стоящего над ним и элемента, стоящего выше и левее этого элемента
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

FillPascalTriangle();
PrintTriangle();

/*
ожидаемый результат:
1
1 1
1 2 1
1 3 3 1
1 4 6 4 1

*/