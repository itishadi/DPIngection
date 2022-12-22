using WithDI;

namespace WithDI
{
    public class ConsoleNotification : IConsoleNotification
    {
        public void NotifiyUserNameChanged(User user)
        {
            Console.WriteLine($"User name changed to: {user.UserName}");
        }
    }


}