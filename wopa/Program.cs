using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wopa
{
    class Program
    {
        static void Main(string[] args)
        {
            WordParser wp = null;
            foreach (string prm in args)
            {
                wp = new WordParser(prm);
            }
        }
    }
}
