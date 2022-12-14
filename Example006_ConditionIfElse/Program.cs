// Так записываются комментарии C#
Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Ну привет, ");
    Console.WriteLine(username);
}