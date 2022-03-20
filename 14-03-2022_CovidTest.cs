using System;
class CovidTest
{
public static void Main()
{
string ans;
Console.WriteLine("Do you have travel history : ");
ans = Console.ReadLine();
if (ans == "yes")
{
	Console.WriteLine("Do you have temperature : ");
	ans = Console.ReadLine();
	if (ans == "yes")
	{
		Console.WriteLine("Do you have cough / sneez : ");
		ans = Console.ReadLine();
		if (ans == "yes")
		Console.WriteLine("Do swab test");
		else
		Console.WriteLine("Quarantine, Fever medicine");
		
	}
	else
	Console.WriteLine("Home quarantine for 28 days");
		
}
else 
Console.WriteLine("Safe Not COVID-19");
}
}