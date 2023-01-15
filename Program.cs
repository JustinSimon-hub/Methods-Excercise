namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();


            Console.WriteLine("What is your favorite planet?");
            var planet = Console.ReadLine();


            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();


            Console.WriteLine("What is your favorite video game?");
            var videogame = Console.ReadLine();

            Console.WriteLine($"Hello {name} we are sending you to {planet} to recover a {animal} that accidently got launched while the astronauts were busy playing {videogame}!");
            
        }
    }
}
