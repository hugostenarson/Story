
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine().ToLower();


if (name == "Hugo" || name == "hugo")
{
    Console.WriteLine("Välkommen!");
}
else if (name == "Daniel" || name == "daniel")
{
    Console.WriteLine("Lite välkommen!");
}
else
{
    Console.WriteLine("Inte välkommen!");
}

// if (name != "Hugo")
// {
// Console.WriteLine("Fuck off!");
// }

Console.ReadLine();