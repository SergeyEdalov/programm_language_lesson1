Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Wow, it`s MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}