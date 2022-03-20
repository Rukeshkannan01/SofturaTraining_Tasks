using System;
class AddSub
{
public void addsub(int num1,int num2)
{
int tol = num1+num2;
Console.WriteLine(tol);
int tol1 = num1-num2;
Console.WriteLine(tol1);
}
}
class MulDiv:AddSub
{
public void muldiv(int num1, int num2)
{
int tol2 = num1*num2;
Console.WriteLine(tol2);
float tol3 = num1/num2;
Console.WriteLine(tol3);
}
}
class BasicCalculator
{
public static void Main()
{
MulDiv obj = new MulDiv();
obj.addsub(10,5);
obj.muldiv(10,5);
}
}