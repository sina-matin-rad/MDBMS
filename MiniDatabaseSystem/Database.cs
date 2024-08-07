// Database.cs
using System.Collections.Generic;
using System.Linq;

public class Database
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public User GetUserById(int id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }

    public void UpdateUser(User user)
    {
        var existingUser = GetUserById(user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
        }
    }

    public void DeleteUser(int id)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            users.Remove(user);
        }
    }
}
