﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

string[] movies= {"lord of the rings", "Gladiator", "Upgrate", "Blade runner"};

for (int i=0; i<movies.Length; i++){
    //Console.WriteLine(movies[i]);
int rank = i+1;
Console.WriteLine(rank + ". "+movies[i]);
}



// Type in 4 movies
string[] movies2 = new string[4];

Console.WriteLine("Type in 4 movies");

// movies2[0] = Console.ReadLine();
// movies2[1] = Console.ReadLine();
// movies2[2] = Console.ReadLine();
// c
for (int j=0; j<movies2.Length; j++){

movies2[j]= Console.ReadLine();
}

Console.WriteLine("\nHere they are alphabeticly");
Array.Sort(movies2);
 for (int i=0; i<movies2.Length; i++){
Console.WriteLine(movies2[i]);

}

// lists
// System Collections .Generic


List<string> shoppingList = new List<string>();


shoppingList.Add("Dreams");
shoppingList.Add("travail");
shoppingList.Add("burger");
shoppingList.Add("programming languages");

for(int i=0; i<shoppingList.Count(); i++){
    Console.WriteLine(shoppingList[i]);
}

shoppingList.Remove("Dreams");
shoppingList.RemoveAt(0);
System.Console.WriteLine("-------------------------------- ");

for(int i=0; i<shoppingList.Count(); i++){
    Console.WriteLine(shoppingList[i]);
}
Console.ReadKey();