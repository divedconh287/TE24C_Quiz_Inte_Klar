int points = 0;
Console.WriteLine("skriv ditt namn");
string namn;
Console.WriteLine($"Välkommen till frågesport{namn}!!! skriv endast bokstaven");
namn = Console.ReadLine().ToLower();

Console.WriteLine("Fråga 1:\n");
Console.WriteLine("a) b) c)");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "b")
{
    points++;
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
    points++;
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
    points++;
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("INCORRECT");
}
Console.WriteLine($"GOOD JOB YOU GOT {points} POINTS");
if (points == 0)
{
    Console.WriteLine("boooo");
}
else if (points == 1)
{
    Console.WriteLine("okej");
}
else if (points == 2)
{
    Console.WriteLine("Det är \"dos\" på spanska, förvånad att du inte visste det.");
}
else
{
    Console.WriteLine("ALLA?!\n");
}

Console.WriteLine("ok hejdå");
Console.ReadLine();
