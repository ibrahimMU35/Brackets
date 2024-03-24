// See https://aka.ms/new-console-template for more information


Console.WriteLine("what is your name?");
string userName=Console.ReadLine();

Console.WriteLine("Nice to meet you "+userName);
// Console.ReadKey();

float num0;
float num1;


Console.WriteLine("input a number");
num0 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("your numher is " + num0);
// Console.ReadKey();
Console.WriteLine("enter your second number ");
num1 =Convert.ToSingle(Console.ReadLine());
float result = num0 / num1 ; 
float resultD= num0/num1 ;
Console.WriteLine("the result is " +result);
Console.WriteLine("your second result is " +resultD);




  Console.WriteLine("Please enter numbers (press 'q' to exit):");

        double total = 0;
        int numberCount = 0;
        double average = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q") // If 'q' is pressed, exit the loop
                break;

            if (double.TryParse(input, out double number)) // If the input is a number
            {
                total += number; // Add to total
                numberCount++;   // Increase the count of numbers
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or press 'q' to exit.");
            }
        }

        if (numberCount > 0)
        {
            average = total / numberCount;
            Console.WriteLine("Average of the entered numbers: " + average);
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }


Console.ReadKey();
