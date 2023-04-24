global using System.Numerics;
global using System.Collections.Generic;
global using RestSharp;
global using System.Text.Json;
global using System.Net;
global using System.Text.Json.Serialization;

Console.WriteLine(" WELCOME TO THE SPACE MISSION!");

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
    if (character == 1)                // If the success is true then it will write information depending on which character you chose.
{
        Console.Clear();
        string information = Vader.GetInformationVader();
        Console.WriteLine(information);                     // Writes out the information in the string from Vader.
}
    if (character == 2)
{
        Console.Clear();
        string information = Skywalker.GetInformationSkywalker();
        Console.WriteLine(information);                     // Writes out the information in the string from Skywalker.
}
    if (character == 3)
{
        Console.Clear();
        string information = Obi.GetInformationObi();
        Console.WriteLine(information);                     // Writes out the information in the string from Obi-Wan Kenobi.
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
string informationstage = Stage.GetInformationStage();
Console.WriteLine(informationstage);                    // Information about the stage which is written after the character stats are displayed.

string input2 = "";

while (input2 != "Infront" && input2 != "Right")            // Here you will need to write and input and depending on what you chose there will be a different outcome of storyline.
{

Console.WriteLine(" Which door will you enter? Door (Right) or Door (Infront).");        // This is the question that pops up every time you don't write an answer.
input2 = Console.ReadLine();


if (input2 == "Infront")
{
        Console.Clear();
        string informationstage2 = Stage.GetInformationStage2();            // Information for stage 2
        Console.WriteLine(informationstage2);

string input3 = "";
        
while (input3 != "Attack" && input3 != "Run" && input2 == "Infront") {   // Here you will need to write and input and depending on what you chose there will be a different outcome of storyline.
    
    Console.WriteLine(" Will you (Attack) or (Run)?");
    input3 = Console.ReadLine();
}

if (input3 == "Attack"){
    if(character == 1)
    {

    Console.Clear();
    string informationstage6Vader = Stage.GetInformationstage6Vader();                // Information for stage 6
    Console.WriteLine(informationstage6Vader);

    }
if (character == 2)
{
    Console.Clear();
    string GetInformationstage6Skywalker = Stage.GetInformationstage6Skywalker();                // Information for stage 6
    Console.WriteLine(GetInformationstage6Skywalker);
}
if (character == 3)
{
    Console.Clear();
    string informationstage6Obi = Stage.GetInformationstage6Obi();                // Information for stage 6
    Console.WriteLine(informationstage6Obi);
}

}
if (input3 == "Run"){
    Console.Clear();
    string informationstage7 = Stage.GetInformationstage7();                // Information for stage 5
    Console.WriteLine(informationstage7);
}

}
if (input2 == "Right")
{
        Console.Clear();
        string informationstage3 = Stage.GetInformationstage3();            // Information for stage 3
        Console.WriteLine(informationstage3);

string input4 = "";

while (input4 != "Entrance" && input4 != "Left" && input2 == "Right") {   // Here you will need to write and input and depending on what you chose there will be a different outcome of storyline.
    
    Console.WriteLine(" Will you go through the (Entrance) or go to the (Left)");
    input4 = Console.ReadLine();
}

if(input4 == "Entrance")
{
    Console.Clear();
    string informationstage5 = Stage.GetInformationstage5();                // Information for stage 5
    Console.WriteLine(informationstage5);
}
if(input4 == "Left")
{
    Console.Clear();
    string informationstage4 = Stage.GetInformationstage4();                // Information for stage 4
    Console.WriteLine(informationstage4);
}

}

}

Console.ReadLine();