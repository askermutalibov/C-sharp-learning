// нужно вывести сумму 2 случайных цифр

int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9  это инициализатор массива с псевдослучайными числами, заданный в пределах от 1 включительно до 9 включительно
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);