﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaselLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglama");
        }
    }
}
