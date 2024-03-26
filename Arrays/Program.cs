// See https://aka.ms/new-console-template for more information
string[] movies= {"lord of the rings", "Gladiator", "Upgrate", "Blade runner"};

for (int i=0; i<movies.Length; i++){
    //Console.WriteLine(movies[i]);
int rank = i+1;
Console.WriteLine(rank + ". "+movies[i]);
}
Console.ReadKey();