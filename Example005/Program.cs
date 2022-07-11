Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "jack")
{
    Console.WriteLine("User Jack");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
