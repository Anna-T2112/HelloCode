Console.Write("ВВедите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "анна")
{
    Console.WriteLine("Ура,это же Анна!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}