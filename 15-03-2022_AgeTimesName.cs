using System;
class AgeTimesName
{
public static void Main()
{
Console.WriteLine("Enter your Name : ");
string Name = Console.ReadLine();
Console.WriteLine("Enter your Age :");
int Age = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=Age)
	{

	Console.WriteLine(Name);
	i++;
	}
}
}