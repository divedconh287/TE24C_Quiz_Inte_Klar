int points = 0;
Console.WriteLine("Välkommen till frågesport!!! skriv endast bokstaven");
Console.WriteLine("Fråga 1:\n");
Console.WriteLine("a) b) c)");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "b")
{
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("INCORRECT");
}

Console.WriteLine("Fråga 2:\n");
Console.WriteLine("a) b) c)");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "b")
{
Console.WriteLine("CORRECT");
}
else
{
Console.WriteLine("INCORRECT");
}

Console.WriteLine("Fråga 3:\n");
Console.WriteLine("a) b) c)");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "b")
{
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("INCORRECT");
}
Console.WriteLine("GOOD JOB YOU GOT uhhh POINTS");

Console.ReadLine();
