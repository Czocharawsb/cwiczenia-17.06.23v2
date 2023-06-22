 namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());

            int maxWidth = height * 2 - 1; 

            for (int row = 1; row <= height; row++)
            {
                int numPluses = row * 2 - 1; 
                int numSpaces = (maxWidth - numPluses) / 2; 

                string spaces = new string(' ', numSpaces);
                string pluses = new string('+', numPluses);

                Console.WriteLine(spaces + pluses);
            }

          

        }
    }
}