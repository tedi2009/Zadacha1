using Zadacha1;

    Time time1 = new Time();

    Console.Write("Време 1: ");
    time1.PrintTime();

    Time time2 = new Time(9, 5, 7);

    Console.Write("Време 2: ");
    time2.PrintTime();

    try
    {
        Time time3 = new Time(10, -5, 20);
        time3.PrintTime();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Грешка: " + ex.Message);
    }