using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}
