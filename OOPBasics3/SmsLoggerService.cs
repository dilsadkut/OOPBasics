using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
