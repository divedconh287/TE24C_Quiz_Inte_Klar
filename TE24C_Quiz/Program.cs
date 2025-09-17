string name;

Console.WriteLine("""
                        88            
                        ""            
                                      
 ,adPPYb,d8 88       88 88 888888888  
a8"    `Y88 88       88 88      a8P"  
8b       88 88       88 88   ,d8P'    
"8a    ,d88 "8a,   ,a88 88 ,d8"       
 `"YbbdP'88  `"YbbdP'Y8 88 888888888  
         88                           
         88 
"""); // https://ascii.co.uk/art/quiz
Console.WriteLine("Skriv ditt namn.");
name = Console.ReadLine();
Console.WriteLine($"Välkommen till frågesport {name}!!!");


while (true)
{

    int points = 0;
    Console.WriteLine("\nFråga 1:\nVad är mitt mellannamn?");
    Console.WriteLine("a) Seven b) Åke c) Acke");
    string answer1 = Console.ReadLine().ToLower();
    if (answer1 == "c")
    {
        points++;
        Console.WriteLine("RÄTT");
    }
    else
    {
        Console.WriteLine("FEL");
    }

    Console.WriteLine("\nFråga 2:\nHur många Harry Potter böcker respektive filmer finns det?");
    Console.WriteLine("a) 7 böcker & 7 filmer b) 7 böcker & 8 filmer c) 8 böcker & 8 filmer");
    string answer2 = Console.ReadLine().ToLower();
    if (answer2 == "b")
    {
        points++;
        Console.WriteLine("RÄTT");
    }
    else
    {
        Console.WriteLine("FEL");
    }

    Console.WriteLine("Fråga 3:\nVad hette mina homestay under höstterminen 2025?");
    Console.WriteLine("a) Yudai & Keita b) Kosuke & Yudai c) Hana & Keita");
    string answer3 = Console.ReadLine().ToLower();
    if (answer3 == "a")
    {
        points++;
        Console.WriteLine("RÄTT");
    }
    else
    {
        Console.WriteLine("FEL");
    }
    Console.Write($"\nGOOD JOB YOU GOT {points} ");
    if (points == 0)
    {
        Console.WriteLine("\nboooo");
    }
    else if (points == 1)
    {
        Console.WriteLine("POINT");
        Console.WriteLine("\nehh det är väl okej, antar jag.");
    }
    else if (points == 2)
    {
        Console.WriteLine("POINTS");
        Console.WriteLine("\nDet är \"dos\" på spanska, förvånad att du inte visste det.");
    }
    else
    {
        Console.WriteLine("POINTS");
        Console.WriteLine("\nGrattis!");
    }
    Console.ReadLine();
    Console.WriteLine("\nFrågesporten är slut nu.");


    Console.WriteLine("Spela igen?\nJa eller nej?");
    string playagain = Console.ReadLine().ToLower();
    if (playagain == "nej")
    {
        break;
    }
}