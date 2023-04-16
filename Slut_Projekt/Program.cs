﻿global using System.Numerics;
global using System.Collections.Generic;
global using RestSharp;
global using System.Text.Json;
global using System.Net;
global using System.Text.Json.Serialization;




Console.WriteLine(" WELCOME TO THE SPACE MAZE!");

Console.WriteLine(" (Press Enter to Proceed)");

Console.ReadLine();
Console.Clear();


int character = 0;
bool success = false;

while (success != true)
{

Console.WriteLine(" Please Pick a Character:");

Console.WriteLine(" | Press (1) for Darth Vadar | " + "  | Press (2) for Luke Skywalker | " + "  | Press (3) for Obi-Wan Kenobi | ");

string input = Console.ReadLine();

success = int.TryParse(input, out character); // Tryparse for choosing character between 1, 2, 3

if (success == true)    // If you pick 1,2 or 3 (success will be true)
{
    if (character == 1)                
{
    Console.Clear();
    Console.WriteLine(" Your Chosen Character Is " + Vader.name + "!");
    Console.WriteLine(" Here Are Your Stats: ");
    Console.WriteLine(" Name: " + Vader.name + "   [HP] = " + Vader.HP + "   [Weapon] = " + Vader.weapon);
}
    if (character == 2)
{
    Console.Clear();
    Console.WriteLine(" Your Chosen Character Is " + Skywalker.name + "!");
    Console.WriteLine(" Here Are Your Stats: ");
    Console.WriteLine(" Name: " + Skywalker.name + "   [HP] = " + Skywalker.HP + "   [Weapon] = " + Skywalker.weapon);
}
    if (character == 3)
{
    
    Console.Clear();

    static void Main(string[] args) {
        string information = Obi.GetInformation();
        Console.WriteLine(information);

    }
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

Console.Clear();
Console.WriteLine(" [Main Objective: Find the hidden shuttle back to earth.]");
Console.WriteLine(" Location: In a hidden capsule with a Door (Right) and a Door (Infront)");


string input2 = "";

while (input2 != "Infront" && input2 != "Right")
{

Console.WriteLine(" Which door will you enter? Door (Right) or Door (Infront)");
input2 = Console.ReadLine();


if (input2 == "Infront")
{
        Console.Clear();
        Console.WriteLine(" [Main Objective: Find the hidden shuttle back to earth.]");
        Console.WriteLine(" Location: You're in a tube. You can see a creature at the end of it.");
        Console.WriteLine(" Will you try to (Attack) it or will you try to (Run) straight through it?");
        
}
if (input2 == "Right")
{
        Console.Clear();
        Console.WriteLine(" [Main Objective: Find the hidden shuttle back to earth.]");
        Console.WriteLine(" Location: You are in a big room where you can see an (Entrance) towards the shuttle.");
        Console.WriteLine(" You can also see a Door (Left) which leads into something interesting.");
        Console.WriteLine(" What will you do? Go to the (Entrance) or will you investigate the Door to the (Left)?");
}
}

Console.ReadLine();