global::System.Object value = Console.Write("Введите имя пользователя: ");
string username = Consol.ReadLine();

if(username == "Маша")
{  
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
