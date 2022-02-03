Console.Write("Введите ваше имя:  ");
string username = Console.ReadLine();

if(username.ToLower() == "сергей")
{
    Console.WriteLine("Добро пожаловать - Серёжа!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}