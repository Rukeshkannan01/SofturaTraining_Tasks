using System;
class N_Tables
{
public static void Main()
{
Console.Write("Enter the number to display the table : ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<=20)
	{
	Console.WriteLine("{0} * {1} = {2}",N,i,(i*N));
	i++;
	}
}
}