// See https://aka.ms/new-console-template for more information

double num1, num2;
string str;
Console.Write("Enter your first number: "); 

num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your second number: ");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("choise your process /,*,-,+");

str = Console.ReadLine().ToString();

switch(str){


    case  "/":
   Console.WriteLine("your result is: " + num1/num2);
   break;

   case "*":
   Console.WriteLine("your result is: " + num1*num2);

   break;
   case "+":
   Console.WriteLine("your result is: " + num1+num2);
   break;

   case "-":
   Console.WriteLine("your result is: " + (num1-num2));
   break;
   default:
   Console.WriteLine("your result is: invalid " );
   break;
   }

   Console.ReadKey();