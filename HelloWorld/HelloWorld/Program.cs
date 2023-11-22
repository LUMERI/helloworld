internal class Program
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        string c = Console.ReadLine();

        if (c == "+")
        {
            Console.WriteLine(a + b); return;
        }else if (c == "-")
        {
            Console.WriteLine(a - b); return;
        }else if (c == "*")
        {
            Console.WriteLine(a * b); return;
        }else if (c == "/")
        {
            Console.WriteLine(a / b); return;
        }
        else
        {
            Console.WriteLine("Ничего не понял");
        }
    }
}