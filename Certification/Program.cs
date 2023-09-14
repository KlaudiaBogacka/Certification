using Certification;

Console.WriteLine("Witaj w naszym programie do oceny robotów sprzątających");
Console.WriteLine();
Console.WriteLine("Aplikacja liczy o ceny robotów");
Console.WriteLine("Wpisz ocenę robota");
Console.WriteLine("Aby zsumować oceny wpisz 'Q'");
Console.WriteLine();

var robot = new RobotInMemory("XiaomiMiRobotVacuum", "X10+");
robot.GradeAdded += RobotGradeAdded;

void RobotGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


while (true)
{
    Console.WriteLine("Podaj ocenę robota");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        robot.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched {e.Message}");
    }
}

var statistics = robot.GetStatistics();
Console.WriteLine($"Wyniki robota: {robot.Name} {robot.Model}");
Console.WriteLine();
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Ocena minimalna {statistics.Min}");
Console.WriteLine($"Ocena maksymalna {statistics.Max}");
Console.WriteLine();