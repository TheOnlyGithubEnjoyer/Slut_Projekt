global using System.Numerics;
global using System.Collections.Generic;
global using RestSharp;
global using System.Text.Json;
global using System.Net;
global using System.Text.Json.Serialization;




Console.WriteLine("WELCOME TO THE SPACE MAZE!");

Console.WriteLine("(Press Enter to Proceed)");

Console.ReadLine();
Console.Clear();


Console.WriteLine("Please Pick a Character:");

Console.WriteLine("| Press (1) for Darth Vadar | " + "  | Press (2) for Luke Skywalker | " + "  | Press (3) for Obi-Wan Kenobi | ");



int character = 0;
bool success = false;

while (success != true)
{

string input = Console.ReadLine();

success = int.TryParse(input, out character); // Tryparse for choosing character between 1, 2, 3

if (success == true)    // If you pick 1,2 or 3 (success will be true)
{
    if (character == 1)                
{
    Console.Clear();
    Console.WriteLine("Your Chosen Character Is Darth Vader!");
    Console.WriteLine("Here Are Your Stats: ");
    Console.WriteLine(" Name: " + Vader.name + "   [HP] = " + Vader.HP + "   [Weapon] = " + Vader.weapon);
}
    if (character == 2)
{
    Console.Clear();
    Console.WriteLine(" Your Chosen Character Is Luke Skywalker!");
    Console.WriteLine(" Here Are Your Stats: ");
    Console.WriteLine(" Name: " + Skywalker.name + "   [HP] = " + Skywalker.HP + "   [Weapon] = " + Skywalker.weapon);
}
    if (character == 3)
{
    Console.Clear();
    Console.WriteLine(" Your Chosen Character Is Obi-Wan Kenobi!");
    Console.WriteLine(" Here Are Your Stats: ");
    Console.WriteLine(" Name: " + Obi.name + "   [HP] = " + Obi.HP + "   [Weapon] = " + Obi.weapon);
}

    if (character > 3)
    {
        success = false;        // If the answer is higher than 3 then it will not continue
    }
    if (character <= 0)         // If the answer is 0 or lower than 0 then it will not continue
    {
        success = false;
    }
}
}

Console.ReadLine();