Console.WriteLine("What time is it?");
string? timeEntered = Console.ReadLine(); 
bool isValidTime = TimeOnly.TryParse(timeEntered, out TimeOnly time);
while (isValidTime == false)
{
    Console.WriteLine("Time is incorrect, please try again. Must enter in following format:");
    Console.WriteLine("H:MM AM/PM e.g. '8:00 PM'");
    timeEntered = Console.ReadLine();
    isValidTime = TimeOnly.TryParse(timeEntered, out time);
}
