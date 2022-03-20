using System;
class ElectricityBill
{
public static void Main()
{
int temp; int total;
Console.WriteLine("Enter the electricity consumed by your house :");
int units = Convert.ToInt32(Console.ReadLine());

if (units<=200)
{
total = units*2;
Console.WriteLine("The rate of electricitu consumed by your house = " + total);
}
else if (units>200 && units<=350)
{
	temp = units - 200;
	total = (200*2)+(temp*3);
	Console.WriteLine("The rate of electricitu consumed by your house = " + total);
}
else if (units>350 && units<=500)
{
	temp = units - 350; 
	total = (200*2) + ((350-200)*3) + (temp*5);
	Console.WriteLine("The rate of electricitu consumed by your house = " + total);
}
else if (units>500)
{
	temp = units - 500; 
	total = (200*2) + ((350-200)*3) + ((500-350)*5) + (temp*7);
	Console.WriteLine("The rate of electricitu consumed by your house = " + total);
}
}
}