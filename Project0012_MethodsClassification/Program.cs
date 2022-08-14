// 1 Группа методов в C#: ничего не возвращают и не принимают

/*
void Method1(); // объявление метола
{
    System.Console.WriteLine("text for first method");
}
Method1(); // вызов метода
*/

// 2 Группа методов в C#: ничего не возвращают и что-то принимают

/*
void Method2(string text)
{
    System.Console.WriteLine(text);
}
Method2("text for second method");
*/

/*
void Method21(string text, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(text);
        i++; // увеличение счётчика на единицу - инкремент, а уменьшение наоборот декремент
    }
}
// Method21("Текст", 4); // хотим вывод этого сообщения 4 раза
*/
// Method21(text: "Текст", count: 4); // задаём значения вручную [можно поменять порядок и указать count вначале, а text в конце]

// 3 Группа методов в C#: что-то возвращают, но ничего принимают

/*
int Method3()
{
    return DateTime.Now.Year; // 
}
int year = Method3();
Console.WriteLine(year);
*/

// 4 Группа методов в C#: что-то возвращают, и что-то принимают

/* // реализован через while, ниже будет реализован через for
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // результат - пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "hello  "); // 10 раз записать в переменную result это сообщение
Console.WriteLine(res); // вывести на экран
*/

/*
string Method4(int count, string text)
{
    string result = String.Empty; // результат - пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "hello  "); // 10 раз записать в переменную result это сообщение
Console.WriteLine(res); // вывести на экран
*/



// цикл в цикле
// вывести таблицу умножения на экран

/*
 for (int i = 2; i <= 10; i++)
 {
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine(); // эту строку добавили для того, чтобы разделить на экране результаты умножения 2 на n, 3 на n, 4 на n и так далее
 }
*/


// Ещё одна задача: в тексте, хранящимся отдельной строкой нужно заменить все пробелы знаками тире (или чёрточками), маленькие буквы "к" заменить большими "К", а большие "С" заменить на маленькими "с"

/*
string text = " — Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty'
//             012345
// s[3] = r (так можно искать буквы в тексте, аналогично с массивами)
string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|'); // меняем пробелы на вертикальную черту
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К'); // меняем строчную "к" на заглавную "К"
System.Console.WriteLine(newText);
// немного видоизменим алгоритм: добавили 126 строку cw(); чтобы просто создать пустую строку, затем newText = Replace с заменой прописных "к" на строчные "К"
*/


//      Новая задача: упорядочивание массива (разобрали на лекции)
//      Для решения задачи используем алгоритм сортировки методом выбора (min max): 
//   1) Находим позицию (индекс) минимального элемента в неотсортированной части массива
//   2) Производим обмен этого значения со значением первой неотсортированной позиции
//   3) Повторяем до тех пор, пока в массиве остаются неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 }; // объявление массива с заданными автором кода числами

void PrintArray(int[] array) // объявление метода void, который выводит неотсортированный массив на экран с циклом for (с условием, что значение счётчика i не должно превысить размер (длину) массива)
{
    int count = array.Length; // предел для цикла в виде размера массива
    for (int i = 0; i < count; i++) // пока счётчик, равный текущему индексу элемента в массиве, меньше длины массива (количества элементов в нём) при изначально заданном ему значении 0, происходит вывод на экран элемента с текущим индексом i. Далее счётчик инкрементируется (плюсуем 1).
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(); // оставляем пустую строку перед методом сортировки массива
}

void SelectionSort(int[] array) // объявление метода void, который сортирует массив
{
    for (int i = 0; i < (array.Length - 1); i++) // в условии вычитаем из длины массива единицу, чтобы алгоритм работал корректно
    {
        int minPosition = i; // вводим новую переменную, именуем её как минимальное значение в массиве и присваиваем ей текущее значение индекса массива
        
        for (int j = (i + 1); j < array.Length; j++) // переменной j присваиваем значение i+1, потому что проверяем следующий элемент (элементы массива, находящиеся в паре)
        {
            if (array[j] < array[minPosition]) minPosition = j; // если элемент массива с текущим индексом j меньше элемента с индексом minPosition, то minPosition будет равным j
        }
        int temporary = array[i]; // вводим переменную и присваиваем ей значение под текущим индексом
        array[i] = array[minPosition]; // присваиваем ей значение минимального элемента, который получили во вложенном цикле
        array[minPosition] = temporary; // окончательно записываем число, записанное под индексом минимального элемента, как минимальное
    }
}
System.Console.WriteLine(); // просто новая строка для удобочитаемости

PrintArray(arr); // выводим на экран неотсортированный массив

SelectionSort(arr); // сортируем массив

System.Console.WriteLine(); // для удобочитаемости

PrintArray(arr); // выводим уже отсортированный массив

System.Console.WriteLine(); // для удобочитаемости



//      Новая задача: упорядочивание массива (домашнее задание с лекции)
//      Для решения задачи используем алгоритм сортировки методом выбора (min max): 
//   1) Находим позицию (индекс) максимального элемента в неотсортированной части массива
//   2) Производим обмен этого значения со значением первой неотсортированной позиции
//   3) Повторяем до тех пор, пока в массиве остаются неотсортированные элементы

int[] AnotherUnsortArray = {4, 7, 1, 18, 8, 2, 21, 0, 94, 1, 41, 103, 2, 93, 146, 0, 9, 14, 71, 17, 90, 43, 188, 16, 35, 48, 42, 72, 82, 178 };

void PrintAnotherUnsortArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < (array.Length - 1); i++)
    {
        int maxPosition = i;
        
        for (int j = (i + 1); j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j; // единственное отличие алгоритма для решения с лекции от алгоритма для сортировки по убыванию. Проверка идёт через максимальный элемент массива.
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintAnotherUnsortArray(AnotherUnsortArray);

SortArray(AnotherUnsortArray);

System.Console.WriteLine();

PrintArray(AnotherUnsortArray);

System.Console.WriteLine();