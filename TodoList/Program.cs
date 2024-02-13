﻿Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO!");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit!");

var userChoice = Console.ReadLine();
Console.WriteLine("User input:" + userChoice);

if(userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}
else if(userChoice == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectedOption("Exit");
}

Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}