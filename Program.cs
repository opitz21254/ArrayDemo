// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] names = new string[10];
names[0] = "Josh";
names[1] = "Mitchell";
//2
//3
names[4] = "Bennet";
names[5] = "Mark";
//6
names[7] = "Marcus";
names [8] = "Brennan";

decimal [] scores = new decimal[10];

for(int i = 0; i < names.Length; i++)
{
    string name = names[i];
    //only continue when name is empty
    if(name == "" || name == null)
    {
        continue;
    }
    Console.WriteLine($"Please enter {name}'s score: ");
    string input = Console.ReadLine();
    decimal score = decimal.Parse(input);
    scores[i] = score;
}

Console.WriteLine("Student          Score");
Console.WriteLine("============================");
for(int i = 0; i < names.Length; i++)
{
     if(name == "" || name == null)
    {
        continue;
    }
    Console.WriteLine(${names[i],-13} {scores}:n1,5");
}