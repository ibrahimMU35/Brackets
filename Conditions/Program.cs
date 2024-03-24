// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome , Tickets are 5$!. Please insert cash.");
int cash = Convert.ToInt32(Console.ReadLine()); 
if (cash < 5){
    Console.WriteLine("you are not enough money");

}

else if (cash == 5){
Console.WriteLine("here is your ticket");
}

else {
    int change = cash - 5 ;
    Console.WriteLine("here is your ticket and " + change + " dollars in change");
}




Console.ReadKey();