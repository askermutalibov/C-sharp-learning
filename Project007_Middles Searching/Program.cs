﻿// нужно вывести на экран точки, лежащие по середине между двумя рандомно (случайным образом) выбранными точками на этом же экране

Console.Clear(); // очищаем консоль от точек, раставленных алгоритмом на предыдущем цикле (с предыдущего dotnet run)
//Console.SetCursorPosition(10, 4); // здесь мы вручную задавали положение курсора на расстоянии 10 пикселей (пробелов) от левого края и 4 пикселей (enter) от верхнего края
//Console.WriteLine("+"); // проставляли в этой точке знак плюса

int xa = 15, ya = 1,
    xb = 1, yb = 10,
    xc = 30, yc = 10;

Console.SetCursorPosition(xa, ya); // переставляем курсор в позицию первой точки (здесь xa - абсцисса для компилятора, а вот ya - ордината для компилятора)
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // присваиваем этим переменным значения абсцисс первой и второй точек для корректной работы алгоритма

int count = 100; // рандомное число, зависит от того, насколько "большую картину" из плюсов мы хотим получить

while (count < 15000)
{
    int what = new Random().Next(0, 3); // [0,3) 0 1 2 // вводим новый рандомный массив из 3 элементов, чтобы в случайном порядке находить середину 2 рандомно взятых точек и проставлять в середине между ними новый знак "+"
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

if (what == 1)
{
    x = (x + xb) / 2;
    y = (y + yb) / 2;
}

if (what == 2)
{
    x = (x + xc) / 2;
    y = (y + yc) / 2;
}

Console.SetCursorPosition(x,y);
Console.WriteLine("+");

count++;
}