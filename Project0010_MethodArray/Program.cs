// Теперь напишем код для поиска элемента в массиве из n элементов, который равен find. Это продвинутая версия 9 проекта.

int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length; // возвращает длину (количество элементов) массива
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
