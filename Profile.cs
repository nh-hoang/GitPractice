using System;

public class Profile
{
    public string FullName { get; set; } = "Nguyen Huy Hoang";
    public string StudentId { get; set; } = "24030366";
    public string ClassName { get; set; } = "DH24CT";

    public void ShowProfile()
    {
        Console.WriteLine("Ho ten: " + FullName);
        Console.WriteLine("MSSV: " + StudentId);
        Console.WriteLine("Lop: " + ClassName);
    }
}