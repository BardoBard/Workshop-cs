void Divide(int a, int b)
{
    if (b == 0)
    {
        throw new Exception("Delen door 0 is niet toegestaan");
    }

    Console.WriteLine(a / b);
}

try
{
    Divide(10, 0); // THROW
}
catch (Exception e) when (e.StackTrace != null && e.StackTrace.Contains("Divide"))
{
    Console.WriteLine(e.Message); // Delen door 0 is niet toegestaan
}