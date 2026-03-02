using System;

class User
{
    public string Username;
    public string Role;
}

class Program
{
    static void Main()
    {
        User user = new User { Username = "admin", Role = "Admin" };

        if (user.Role == "Admin")
            Console.WriteLine("Access Granted to Admin Panel");
        else
            Console.WriteLine("Access Denied");
    }
}