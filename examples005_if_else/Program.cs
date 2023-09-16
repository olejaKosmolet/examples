Console.WriteLine("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else 
{
    Console.WriteLine($"Привет, {userName} ");
}