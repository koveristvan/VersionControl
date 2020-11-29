using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Forms;

namespace Beadando__Z86RKF
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        ReaEstateEntities context = new ReaEstateEntities();
        List<Realestate> realestates;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            context.Realestate.Load();
            rebindingsource.DataSource = context.Realestate.Local;
            dataGridView1.DataSource = rebindingsource;
            
        }


        public void LoadData()
        {
            realestates = context.Realestate.ToList();
           
        }

        private void saveall_Click(object sender, EventArgs e)
        {
            createexcel();
        }

        public void createexcel()
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        public void CreateTable()
        {
            string[] headers = new string[]
                {
                     "Cím",
                     "Négyzetméter",
                     "Szín",
                     "Fekvés",
                     "Szintek száma",
                     "Medence",
                     "E-mail",
                };
            xlSheet.Cells[1, 1] = headers[0];
            xlSheet.Cells[1, 2] = headers[1];
            xlSheet.Cells[1, 3] = headers[2];
            xlSheet.Cells[1, 4] = headers[3];
            xlSheet.Cells[1, 5] = headers[4];
            xlSheet.Cells[1, 6] = headers[5];
            xlSheet.Cells[1, 7] = headers[6];
            object[,] values = new object[realestates.Count, headers.Length];


            int counter = 0;
            foreach (Realestate re in realestates)
            {
                values[counter, 0] = re.LOCATION;
                values[counter, 1] = re.SQUAREM;
                values[counter, 2] = re.COLOR;
                values[counter, 3] = re.DIRECTION;
                values[counter, 4] = re.LEVELS;
                if (re.POOL==true)
                {
                    values[counter, 5] = "Van";
                }
                else
                {
                    values[counter, 5] = "Nincs";
                }
                
                values[counter, 6] =re.EMAIL ;
                counter++;
            }

           string GetCell(int x, int y)
            {
                string ExcelCoordinate = "";
                int dividend = y;
                int modulo;

                while (dividend > 0)
                {
                    modulo = (dividend - 1) % 26;
                    ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                    dividend = (int)((dividend - modulo) / 26);
                }
                ExcelCoordinate += x.ToString();

                return ExcelCoordinate;
            }

            xlSheet.get_Range(
                         GetCell(2, 1),
                         GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

        }

        private void drawbutton_Click(object sender, EventArgs e)
        {
            
        }







        //public void save1_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow.Index >= 0)
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
        //        txtID.Text = row.Cells[0].Value.ToString();
        //        txtName.Text = row.Cells[1].Value.ToString();
        //        txtCountry.Text = row.Cells[2].Value.ToString();
        //    }

        //}

    }
}
