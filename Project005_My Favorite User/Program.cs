Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "владимир ильич")
{
    Console.WriteLine("Здравия желаю, Владимир Ильич!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}