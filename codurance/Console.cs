using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codurance
{
    public class Console : IConsole
    {
        public void Print(string input)
        {
            System.Console.WriteLine(input);
        }
    }
}
