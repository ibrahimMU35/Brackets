using System.Security.Cryptography;

namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        Program prog = new Program();
        prog.MeetAlien();
        



        //----------------
    int result = Multiply(3,5);

    System.Console.WriteLine("the result is " + result);
    if(result%2 == 0)
    {
        System.Console.WriteLine("The " + result + " is even");
    }else{
        System.Console.WriteLine("The " + result + " is odd"); 
    }




        Console.ReadKey();
    }
    void MeetAlien(){

Random rand = new Random();

string name= "X-" + rand.Next(10,9999);
int age = rand.Next(10,500);
System.Console.WriteLine("hi im " + name);
System.Console.WriteLine("im "+age +" years old");
System.Console.WriteLine("im an alien");
    }



    static int Multiply(int x, int y){

        int result = x * y ;
        return result;
    }
}
