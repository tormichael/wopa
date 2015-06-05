using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace wopa
{
    public class WordParser
    {
        Microsoft.Office.Interop.Word.Application _word;

        public WordParser(String aDocFileName)
        {
            _word = new Microsoft.Office.Interop.Word.Application();
            Document doc = _word.Documents.Open(aDocFileName);

            if (doc.Tables.Count > 0)
            foreach (Table tab in doc.Tables)
            {
                foreach(Row rw in tab.Rows)
                {
                    foreach (Cell cl in rw.Cells)
                    {
                        Console.WriteLine(cl.Range.Text);
                    }
                }
            }
            doc.Close();
        }
    }
}
