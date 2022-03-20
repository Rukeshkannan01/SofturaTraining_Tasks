using System;  
public abstract class Cal  
{  
public abstract void Tol();  
}  
class Add : Cal  
{  
public override void Tol()  
{  
int n1=10,n2=5;
Console.WriteLine("sum = "+ (n1+n2));  
}
}
class Sub : Cal  
{  
public override void Tol()
{
int n1=10,n2=5;
Console.WriteLine("Sub = " + (n1-n2));
} 
} 
class Mul : Cal  
{  
public override void Tol()
{
int n1=10,n2=5;
Console.WriteLine("Mul = " + (n1*n2));
} 
} 
class Div : Cal  
{  
public override void Tol()
{
double n1=10,n2=5;
Console.WriteLine("Div = " + (n1/n2));
}   
}  

class TestAbstract  
{  
public static void Main()  
{  
Cal addobj = new Add();  
addobj.Tol();  
Cal subobj = new Sub();  
subobj.Tol(); 
Cal mulobj = new Mul();  
mulobj.Tol(); 
Cal divobj = new Div();  
divobj.Tol(); 
}  
}  