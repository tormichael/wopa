using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode;

namespace wopax
{
    class Program
    {
        static void Main(string[] args)
        {
            DocX doc = DocX.Load(@"T:\wopa\src\1.docx");
            if (doc.Tables.Count() > 0)
            {
               foreach(Table tab in doc.Tables)
               {
                   foreach(Row rw in tab.Rows)
                   {
                       Console.Write(rw.ToString());
                   }
               }
            }
        }
    }
}
