using System;
class TvChannelPackage
{
public static void Main()
{
Console.Write("Select TV channel package - A, B, and C : ");
String package = Console.ReadLine();
switch(package)
	{
	case ("A" or "a"):
		Console.WriteLine("The rate for package A = 250");
		break;
	case ("B" or "b"):
		Console.WriteLine("The rate for package B = 450");
		break;
	case ("C" or "c"):
		Console.WriteLine("The rate for package C = 350");
		break;
	default:
		Console.WriteLine("Invalid Package");
		break;
	}
}
}