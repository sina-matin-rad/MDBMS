// Program.cs
using System;

class Program
{
    static void Main()
    {
        Database db = new Database();

        // Sample menu
        while (true)
        {
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. View Users");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Delete User");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter User ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter User Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter User Email: ");
                    string email = Console.ReadLine();
                    db.AddUser(new User { Id = id, Name = name, Email = email });
                    break;

                case "2":
                    foreach (var user in db.GetUsers())
                    {
                        Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
                    }
                    break;

                case "3":
                    Console.Write("Enter User ID to Update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    var existingUser = db.GetUserById(updateId);
                    if (existingUser != null)
                    {
                        Console.Write("Enter New Name: ");
                        existingUser.Name = Console.ReadLine();
                        Console.Write("Enter New Email: ");
                        existingUser.Email = Console.ReadLine();
                        db.UpdateUser(existingUser);
                    }
                    break;

                case "4":
                    Console.Write("Enter User ID to Delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    db.DeleteUser(deleteId);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
