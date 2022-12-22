﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOutDI;

    public class User
    {
        private ConsoleNotification _notificationService;
        public string UserName { get; set; }

        public User(string userName)
        {
            UserName = userName;
            _notificationService = new ConsoleNotification();
        }

        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
            _notificationService.NotifiyUserNameChanged(this);
        }
    }

