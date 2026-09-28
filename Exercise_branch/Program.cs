namespace Exercise_branch;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hej, vad heter du?: ");

        string name = Console.ReadLine();

        while (true)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Fel! Du måste ange namn: ");
                name = Console.ReadLine();
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Välkommen, {name}!");
    }
}
