using System;
class MarkSheet
{
public static void Main()
{
int [] marks = new int[5];
for(int i=0;i<5;i++)
	{
	Console.Write("Enter your subject {0} Marks : ",i+1);
	marks[i]=Convert.ToInt32(Console.ReadLine());
	}
int sum=0;
//float per;
for(int i=0;i<5;i++)
sum += marks[i];
Console.WriteLine("Total is {0}",sum);
Console.WriteLine("Percentage is {0}",float(sum/5));
}
}