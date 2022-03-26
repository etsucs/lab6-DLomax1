CalculateRetail();

void CalculateRetail()
{
System.Console.WriteLine("Please enter the wholesale cost.");
string Wholesale = Console.ReadLine();
System.Console.WriteLine("Please enter the markup percentage as a decimal(ex: .5) ");
string MarkUp = Console.ReadLine();
double Retail = Double.Parse(Wholesale) * Double.Parse(MarkUp) + Double.Parse(Wholesale);
System.Console.WriteLine($"Your retail price is $ {Math.Round(Retail, 2)}");
}
