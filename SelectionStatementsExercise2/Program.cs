namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject  = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is trash");
                    break;
                case "science":
                    Console.WriteLine("The mitochondria is the powerhouse of the cell");
                    break;
                case "pe":
                case "p.e":
                case "physical education":
                    Console.WriteLine("Get your sweat on");
                    break;
                case "history":
                    Console.WriteLine("studious legend");
                    break;
                case "geography":
                    Console.WriteLine("Learning about other countries like Djibouti was so fun");
                    break;
                default:
                    Console.WriteLine("That's awesome!");
                    break;
            }
        }
    }
}