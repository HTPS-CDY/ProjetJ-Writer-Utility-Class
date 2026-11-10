using Writer;
{
    Wr.Write("test.txt", "hello world");
    List<string> lines = Rea.Read("test.txt");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
    Reatxt.Read("test.txt");
}