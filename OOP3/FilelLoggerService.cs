using System;

namespace OOP3
{
    class FilelLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglama");
        }
    }
}
