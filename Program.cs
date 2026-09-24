namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            char lletra = rand.Next(65-91);
            Console.WriteLine($"{(string)lletra}");

    }
}
