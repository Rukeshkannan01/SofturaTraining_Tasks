using System;
class VAT
{
public void Vat(double vatper)
{
 double vat=vatperx*(1+(0.2));
 Console.WriteLine(vat);
}
}
class GST:VAT
{
 public void Gst(float tol, float gstper)
{
   float gst =(tol*gstper)/100;
   Console.WriteLine(gst);
}
public static void Main()
{
  GST obj= new GST();
  obj.Vat(20);
  obj.Gst(1000,20);
}
}