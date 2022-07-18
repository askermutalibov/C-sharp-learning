// В этом проекте сделаем то же самое, что и в предыдущем, но с применением генератора псевдослучайных чисел, методов, передачи в метод массива и заполнить массив нужным количеством элементов

void FillArray(int[] collection) // void это метод. В данном конкретном случае - метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    
}

void PrintArray(int[] col) // А это метод вывода массива на экран.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // когда алгоритм найдёт первое число, равное записанному в переменную [find], он остановит поиск дополнительных индексов, под которыми хранятся искомые нами числа и выведет на экран только тот индекс, который он нашёл первым. Таким образом, если в массиве из 10 элементов будет 3 четвёрки, то на экран он выведет только один индекс, соответствующий позиции четвёрки (цифры 4), ближайшей к первому элементу массива.
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // по умолчанию наполнен нулями


FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf (array, 7);
Console.Write("element position in this random array is: "); 
Console.Write(pos); // этот алгоритм выводит на экран индекс элемента в рандомно сформированном массиве, в котором хранится число, равное 4 (этот параметр можно изменить в 51 строке через оператор IndexOf)