using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BurgerApp
{
    public partial class Form1 : Form
    {
        Burger burg1, burg2, burg3, burg4, burg5;
        int rowIndex = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Burger burg1 = new Burger(((Button)sender).Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (burg1 != null)
            {
                burg1.Endtime = DateTime.Now;
                ExcelDocument excelDoc = new ExcelDocument();
                try
                {
                    string valueCol1 = rowIndex.ToString();
                    string valueCol2 = burg1.Name;
                    string valueCol3 = burg1.Starttime.ToString();
                    string valueCol4 = burg1.Endtime.ToString();
                    string valueCol5 = (burg1.Endtime - burg1.Starttime).ToString();
                    excelDoc.SetCellValue(valueCol1, rowIndex, 1);
                    excelDoc.SetCellValue(valueCol2, rowIndex, 2);
                    excelDoc.SetCellValue(valueCol3, rowIndex, 3);
                    excelDoc.SetCellValue(valueCol5, rowIndex, 4);
                    rowIndex++;
                }
                catch (Exception error)
                {
                    excelDoc.Close();
                    // обрабатываем саму ошибку
                }
                //excelDoc.Visible = true;
                excelDoc.Close();
            }
        }
    }
}
