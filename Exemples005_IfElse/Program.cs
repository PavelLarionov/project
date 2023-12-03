Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Marina")
{
    Console.WriteLine("Ура, это же Марина");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}