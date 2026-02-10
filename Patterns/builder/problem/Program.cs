namespace problem;

public class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("John", 21, "email@email.com", "123456789", "123 Street");
        User user2 = new User("John");
        Console.WriteLine("User 1 can drive: " + user1.CanDrive);
        Console.WriteLine("User 2 can drive: " + user2.CanDrive);
    }
}
