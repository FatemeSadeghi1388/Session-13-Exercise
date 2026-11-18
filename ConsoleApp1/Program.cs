Console.Clear();
Console.BackgroundColor=ConsoleColor.Blue;
Console.ForegroundColor=ConsoleColor.White;
Console.Write("Please enter your working hours: ");
try
{var hours = Convert.ToInt32(Console.ReadLine());
var dollar = Convert.ToInt32(3);
var wages = Convert.ToDouble(hours * dollar);
Console.WriteLine($"Your wages: {wages}");
var tax = Convert.ToDouble(wages * 5/100);
Console.WriteLine($"Your wages including tax: {tax}");
}
finally
{
    Console.WriteLine("Please note:You have entered a value that is not a number!");
}
