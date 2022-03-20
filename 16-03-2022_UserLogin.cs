using System;
class UserLogin
{
public void Login(string mailId, string passWord)
{
Console.WriteLine("Email ID");
Console.WriteLine("Password");
}
public void Login(string memberId, int Pin)
{
Console.WriteLine("Membership ID");
Console.WriteLine("PIN");
}
public void Login(long mobNo, int Pin)
{
Console.WriteLine("Mobile number");
Console.WriteLine("PIN");
}
public static void Main()
{
UserLogin obj = new UserLogin();
obj.Login("email2022@gmail.com","Email_10");
obj.Login("abcd123",1928);
obj.Login(6382325571,2001);

// obj.login()  ?
}
}
