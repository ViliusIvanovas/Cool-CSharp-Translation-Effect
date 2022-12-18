internal class Program
{
    static void Main(string[] args)
    {
        TraslationEffect("これは非現実的なテストです", "This is an impractical test");
    }
    static void TraslationEffect(string original, string translated)
    {
        Console.SetCursorPosition((Console.WindowWidth - original.Length) / 2, Console.CursorTop);
        Console.Write(original);

        Console.SetCursorPosition((Console.WindowWidth - translated.Length) / 2, Console.CursorTop);

        foreach (char c in translated)
        {
            Thread.Sleep(100);
            Console.Write(c);
        }
    }
}