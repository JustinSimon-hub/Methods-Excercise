
namespace MethodsExercise

{
     public class Program
    {
    public static int Sum (int x, int y)
    {
var answer = (x + y);
return answer;
    }
public static int Difference (int q, int w)
{
    var difference = (q - w);
    return difference;

}
public static int Quotient (int t, int y)
{
    var quotient = ( t - y);
    return quotient;
}



         static void Main(string[] args)
        {
            // exercise 2
int sumofnum = Sum(3 ,6);
Console.WriteLine(sumofnum);
            


int quotofnum = Quotient(4, 2);
Console.WriteLine(quotofnum);

int diffofnum = Difference( 5 ,1);
Console.WriteLine(diffofnum); 
//end of exercise 2

// excercise 1
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();


            Console.WriteLine("What is your favorite planet?");
            var planet = Console.ReadLine();


            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();


            Console.WriteLine("What is your favorite video game?");
            var videogame = Console.ReadLine();

            Console.WriteLine($"Hello {name} we are sending you to {planet} to recover a {animal} that accidently got launched while the astronauts were busy playing {videogame}!");
            // end of excercise 1
            
        }
    }
}
