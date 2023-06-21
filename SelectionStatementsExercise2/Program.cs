namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Switch-Case

            Console.WriteLine("What is your favorite subject in school?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine("I love science.");
                    break;
                case "english":
                    Console.WriteLine("I like english too!");
                    break;
                case "social studies":
                    Console.WriteLine("I don't care for social studies too much.");
                    break;
                case "computers":
                    Console.WriteLine("That is the best subject - computer class!");
                    break;
                default:
                    Console.WriteLine("I cannot remember if I took that subject.");
                    break;

            }


        }
    }
}