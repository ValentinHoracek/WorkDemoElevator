// See https://aka.ms/new-console-template for more information
using WorkDemoElevator;

Console.WriteLine("Elevator Demo");


// Vytvoreni instance vytahu
Elevator elevator = new();

// Simulace nekolika pozadavku
//elevator.CallFrom(5);
//elevator.MoveTo(3);
//elevator.CallFrom(9);
//elevator.CallFrom(10);
//elevator.MoveTo(1);

Console.WriteLine("------");
Console.WriteLine("Operating Instructions:");
Console.WriteLine("exit - To end simulation.");
Console.WriteLine("m - to board an elevator, following with number of the floor to go to");
Console.WriteLine("c - to call an elevator, following with number of the floor");

while (true)
{
    var input = Console.ReadLine();
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (input.Equals("move", StringComparison.OrdinalIgnoreCase))
    {
        var floor = Convert.ToInt32(Console.ReadLine());
        if (elevator.ValidateFloor(floor))
        {
            elevator.MoveTo(floor);
        }
        else
        {
            Console.WriteLine("Floor with this number doesnt exist.");
        }
    }
    if (input.Equals("call", StringComparison.OrdinalIgnoreCase))
    {
        var floor = Convert.ToInt32(Console.ReadLine());
        if (elevator.ValidateFloor(floor))
        {
            elevator.CallFrom(floor);
        }
        else 
        {
            Console.WriteLine("Floor with this number doesnt exist.");
        }
    }
}