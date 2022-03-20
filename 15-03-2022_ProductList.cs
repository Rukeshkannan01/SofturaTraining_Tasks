using System;
class ProductList{
  public static void Main(){
     string[][] Product=new string[3][];
     Product[0]=new string[]{"Parle-G","Good day","Oreo","marigold"};
     Product[1]=new string[]{"Five star","Munch","dairy milk","Kit kat","Milkybar"};
     Product[2]=new string[]{"mazza","slize","thumps up","coco","sprite","7-up"};  
for(int i=0;i<Product.Length;i++) 
  {
   for(int j=0;j<Product[i].Length;j++)
   Console.Write(Product[i][j]+" \t");
   Console.WriteLine();
   }}
}