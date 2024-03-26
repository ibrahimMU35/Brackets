// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Xml.XPath;

for (int i=0; i<=10; i++){
    Console.WriteLine(i);
}

for(double j=10; j>=0; j-- )
{
    Console.WriteLine(j);
} 


Console.WriteLine("LOPPS");
for(double a=0; a<=10; a++){
    double result = Math.Pow(2,a);
    Console.WriteLine(result);
}
// wait for looading


Console.WriteLine("how many cool numbers do you want ");


int number= Convert.ToInt32(Console.ReadLine());


for(int h=1; h<=number; h++){
    double resultV=Math.Pow(2,h);
Console.WriteLine(resultV);
}


//genereate number 

Random numberGen= new Random();


//numberGen.Next(0,4);

// while loops 
int roll2= 0;


int roll= 0;
int attemp = 0;
Console.WriteLine("Press enter to roll the dice...");
while(roll!= 6 || roll2 !=6){
    Console.ReadKey();

roll = numberGen.Next(1,7);
roll2 = numberGen.Next(1,7);
    Console.WriteLine("first dice :  "+roll);
    Console.WriteLine("second dice : "+roll2);
attemp++;
}

Console.WriteLine("it tooks you "+ attemp+" attemps to roll a six .");

Console.ReadKey();
