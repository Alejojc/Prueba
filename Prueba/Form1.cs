using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Prueba
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ExcelClass ExcObj = new ExcelClass();
            ExcObj.ExcelAbrir(@"C:\Users\USER\Pictures\Prueba.xlsx", 1,true);
            ExcObj.ExcelCantidadFilas();
            int Rows = ExcObj.Row;
            for (int i =1; i<=Rows;i++)
            {
                Console.WriteLine(ExcObj.ExcelRangoObtener("A"+i));
                ExcObj.ExcelRangoEscribir("B" + i, "Procesando..."+i);
            }
            ExcObj.ExcelSalvar();

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string TextoBs = TextoBuscar.Text;
            Controladores Inst = new Controladores();
            Inst.Driver("https://www.youtube.com/");
            while (!Inst.IsVisible("//form//*[@id='search']")) { }
            Inst.SetearXP("//form//*[@id='search']", TextoBs);
            Inst.Esperar(2);
            Inst.Clear("//form//*[@id='search']");
            Inst.SetearXP("//form//*[@id='search']", "Holaaaa");
            //Inst.ClickXP("//*[@id='search-icon-legacy']");
        }
    }
}
