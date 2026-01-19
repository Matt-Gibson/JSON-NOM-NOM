using System.Text.Json;
using System.Text.Json.Serialization;

// Obligatory Vent to Dan
Console.WriteLine("Hola, Dan!");
Console.WriteLine("I don't type or speak spanish..... so let's stop that right now.");
Console.WriteLine("Honestly, Man.... I've not been to sleep in... I'm thinking this is over 2 actual days now...");
Console.WriteLine("Don't worry though, my record without hallucinations is a solid 4 days! So we're in the safe zone.");
Console.WriteLine("Anyways, lots of catch up and the usual life combo of work and taking care of the human spawn....");
Console.WriteLine("Then last night I stayed in the hospital with my Mom again, to let my Dad have a break and.... it's been rough");
Console.WriteLine("Constant vigilance for safety, along with deciding whether or not to go along with a delusion or snap someone back to reality...");
Console.WriteLine("They all hit different when someone doesn't recognize you anymore, you already feel like you're all tapped out");
Console.WriteLine("And then you feel something you hadn't even bothered to take inventory of... something you very much took for granted... slip right through the cracks...");
Console.WriteLine("Enough of a vent... and a long story short, sticking strictly by the prompt here\n\n");


// Hard coding json file path.... yeah no fancy configuration going on just yet
string jsonpath = "../../../data.JSON";

// Open File
using (StreamReader sr = new StreamReader(jsonpath))
{
    //Read File
    string filecontents = sr.ReadToEnd();

    // Deserialize into Objects (DigiMans)
    DigiMan[] digiMen = JsonSerializer.Deserialize<DigiMan[]>(filecontents);

    // Loop over Object Array and Print
    foreach (DigiMan digiMan in digiMen)
    {
        digiMan.Display();
        Console.WriteLine();
    }

}


Console.WriteLine("Until next time Dan");
Console.ReadKey();




// DigiMan Class
public class DigiMan
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Weakness { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Type: {this.Type}");
        Console.WriteLine($"Weakness: {this.Weakness}");
    }
}
