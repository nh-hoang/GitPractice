using System;

public class Login
{
    public static bool CheckLogin(string username, string password)
    {
        return username == "admin" && password == "123456";
    }

    public static void Main2()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (CheckLogin(username, password))
            Console.WriteLine("Dang nhap thanh cong!");
        else
            Console.WriteLine("Sai tai khoan hoac mat khau!");
    }
}