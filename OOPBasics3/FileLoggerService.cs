using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
