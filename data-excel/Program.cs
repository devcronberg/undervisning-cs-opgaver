using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using ClosedXML.Excel;

namespace data_excel
{
    class Program
    {



        static void Main(string[] args)
        {
            using (var workbook = new XLWorkbook())
            {
                var primTal = FindPrimtal(100000);
                var ws = workbook.Worksheets.Add("Primtal");
                ws.Cell(1, 1).Value = "#";
                ws.Cell(1, 2).Value = "Primtal";
                for (int row = 0; row < primTal.Count; row++)
                {
                    ws.Cell(row + 2, 1).Value = row + 1;
                    ws.Cell(row + 2, 2).Value = primTal[row];
                }
                var rngHeaders = ws.Range("A1:B1");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                workbook.SaveAs(@"c:\temp\primtal.xlsx");
            }
        }

        // Jeg får altså ikke 12 for metode til at finde primtal 
        // men den virker. Burde nok bruge yield og iøvrigt se 
        // nærmere på https://stackoverflow.com/questions/1042902/most-elegant-way-to-generate-prime-numbers
        public static List<int> FindPrimtal(int tilVærdi)
        {
            List<int> listeAfPrimtal = new List<int>();
            bool erPrimtal = true;
            for (int i = 2; i <= tilVærdi; i++)
            {
                for (int j = 2; j <= tilVærdi; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        erPrimtal = false;
                        break;
                    }
                }
                if (erPrimtal)
                {
                    listeAfPrimtal.Add(i);
                }
                erPrimtal = true;
            }
            return listeAfPrimtal;
        }
    }
}


