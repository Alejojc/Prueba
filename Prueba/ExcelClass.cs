using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace Prueba
{
    internal class ExcelClass
    {
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static Excel.Workbook MyBook = null;
        private static Excel.Range MyRange = null;
        private int row;
        private string data;
        public ExcelClass()
        {
            row = 0;
        }
        public void ExcelAbrir(string Ruta, int Hoja, bool Tipo)
        {
            MyApp = new Excel.Application();
            MyApp.Visible = Tipo;
            MyBook = MyApp.Workbooks.Open(Ruta);
            MySheet = (Excel.Worksheet)MyBook.Sheets[Hoja];
            MyRange = MySheet.UsedRange;
        }
        public void SaveAsCSV(string URL)
        {
            MySheet.SaveAs(URL, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSVWindows);

        }
        public void RefreshPivots()
        {
            Console.WriteLine("Count: " + MyApp.Worksheets.Count);
            /*
            foreach (Microsoft.Office.Interop.Excel.Worksheet pivotSheet in MyBook.Sheets)
            {
                Microsoft.Office.Interop.Excel.PivotTables pivotTables = pivotSheet.PivotTables();
                int pivotTablesCount = pivotTables.Count;
                if (pivotTablesCount > 0)
                {
                    for (int i = 1; i <= pivotTablesCount; i++)
                    {
                        Console.WriteLine("Item: "+pivotSheet.Name);
                        pivotTables.Item(i).RefreshTable();
                    }
                }
            }*/
            MyBook.RefreshAll();
            Console.WriteLine("Ok actualizado");
        }
        public void ExcelGuardar()
        {
            try
            {
                MyBook.Save();
            }
            catch (Exception) { }
        }
        public void ExcelSalvar()
        {
            Console.WriteLine("Excel Salvar");
            MyBook.Save();
            MyBook.Close(true, null, null);
            MyApp.Quit();
        }

        public void ExcelRangoEscribir(string Rango, string Valor)
        {
            try
            {
                MyRange.Worksheet.Range[Rango].Value = Valor;
            }
            catch (Exception) { }
        }

        public string ExcelRangoObtener(string Rango)
        { return data = System.Convert.ToString(MyRange.Worksheet.Range[Rango].Value); }

        public void ExcelCantidadFilas()
        { row = MyRange.Rows.Count; }

        public void ExcelCerrar()
        {
            MyBook.Close(true, null, null);
            MyApp.Quit();
            /*foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == "EXCEL")
                {
                    //proceso.Kill();
                }
            }*/
        }
        //VALORES MODFICABLES
        public int Row { set { row = value; } get { return row; } }

    }
}

