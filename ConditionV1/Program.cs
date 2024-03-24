// See https://aka.ms/new-console-template for more information

int age;
int height;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Please input your age:");
age= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please input your height(cm):");
height= Convert.ToInt32(Console.ReadLine());

if (age >= 18 && height >= 160 ){
    Console.WriteLine("you can enter to the rollercoster");

}else 
{
    Console.WriteLine("these requirements are not enough to enter the rollercoster");
}

Console.ReadKey();//wait befor closing