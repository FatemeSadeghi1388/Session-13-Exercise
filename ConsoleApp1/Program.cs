Console.Write("Please enter your working hours: ");
var hours = Convert.ToInt32(Console.ReadLine());
var dollar = Convert.ToInt32(3);
var wages = Convert.ToDouble(hours * dollar);
Console.WriteLine($"Your wages: {wages}");
var tax = Convert.ToDouble(wages * 5/100);
Console.WriteLine($"Your wages including tax: {tax}");

