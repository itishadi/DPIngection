using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOutDI
{
    public class ConsoleNotification
    {
        public void NotifiyUserNameChanged(User user)
        {
            Console.WriteLine($"User name changed to: {user.UserName}");
        }
    }

}
