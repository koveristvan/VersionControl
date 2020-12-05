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
using System.Diagnostics;

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

            
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 50;
            headerRange.Interior.Color = Color.DeepSkyBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            drawingpanel.Refresh();
            using (Graphics g = drawingpanel.CreateGraphics())

            {

                Pen mypen = new Pen(Color.Black);
                Pen mypen2 = new Pen(Color.Black);
                SolidBrush mybrush = new SolidBrush(Color.Black);
                SolidBrush mybrush2 = new SolidBrush(Color.Brown);
                SolidBrush windowbrush = new SolidBrush(Color.DarkGray);
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    //változók beolvasása a datagridviewból
                    
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string Location = selectedRow.Cells["LOCATION"].Value.ToString();
                    int Levels = int.Parse(selectedRow.Cells["LEVELS"].Value.ToString());
                    string Colour = Convert.ToString(selectedRow.Cells["COLOR"].Value);
                    float Squarem = float.Parse(selectedRow.Cells["SQUAREM"].Value.ToString());
                    string Direction = Convert.ToString(selectedRow.Cells["DIRECTION"].Value);
                    bool Pool = bool.Parse(selectedRow.Cells["POOL"].Value.ToString());
                    float multiple = 2;
                    int width = int.Parse((Squarem * multiple).ToString());

                    LocationTextbox.Text = Location;
                    SquareTextBox.Text = Squarem.ToString();
                    DirectionTextBox.Text = Direction;
                    LevelsTextBox.Text = Levels.ToString();

                    

                    // házszín
                    switch (Colour)
                    {
                        case "Red":
                            mybrush.Color = Color.Red;
                            break;
                        case "Blue":
                            mybrush.Color = Color.Blue;
                            break;
                        case "Green":
                            mybrush.Color = Color.Green;
                            break;
                        case "Yellow":
                            mybrush.Color = Color.Yellow;
                            break;

                        default:
                            mybrush.Color = Color.White;
                            MessageBox.Show("A ház igazi színe nincs a rendszerben");
                            break;
                    }
                    //egyszintes ház
                    if (Levels == 1)
                    {
                        g.DrawRectangle(mypen, 50, 187, width, 50);
                        g.FillRectangle(mybrush, 50 + 1, 187 + 1, width - 1, 50 - 1);

                        Point point1 = new Point(50, 187);
                        Point point2 = new Point((50 + (width) / 2), 150);
                        Point point3 = new Point(50 + width, 187);
                        Point[] trianglepoints = { point1, point2, point3 };
                        g.FillPolygon(mybrush2, trianglepoints); //tető
                        g.FillRectangle(windowbrush, 70, 200, 20, 20);

                    }
                    //többszintes ház
                    if (Levels != 1)
                    {
                        for (int i = 0; i < Levels; i++)
                        {
                            g.DrawRectangle(mypen, 50, 187 - (50 * i), width / Levels, 50);
                            g.FillRectangle(mybrush, 50 + 1, 187 - (50 * i) + 1, width / Levels - 1 * Levels / multiple, 50 - 1);
                            if (Squarem / Levels > 50)
                            {
                                g.FillRectangle(windowbrush, 70, 200 - (i * 50), 20, 20);
                            }

                            if (i > 0 & Squarem > 100)
                            {
                                g.FillRectangle(windowbrush, width / Levels + 10, 200 - (i * 50), 20, 20);
                            }
                        }

                    }
                    //medence
                    if (Pool == true)
                    {
                        g.DrawLine(mypen2, 50 + width / Levels + 20, 237, 50 + width / Levels + 70, 237);
                        g.DrawLine(mypen2, 50 + width / Levels + 20, 237, 50 + width / Levels + 20, 207);
                        g.DrawLine(mypen2, 50 + width / Levels + 70, 237, 50 + width / Levels + 70, 207);
                        g.DrawEllipse(mypen2, 50 + width / Levels + 20, 197, 50, 20);
                        g.FillEllipse(new SolidBrush(Color.Blue), 50 + width / Levels + 20, 197, 50, 20);
                    }
                    g.FillRectangle(mybrush2, width / Levels, 200, 20, 37); //ajtó

                }

            }
        }

        private void copymail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string mail = selectedRow.Cells["EMAIL"].Value.ToString();

                Clipboard.SetText(mail);
            }
        }

        private void save1_Click(object sender, EventArgs e)
        {
            
            string URL=LocationTextbox.Text;
            
            Process.Start("https://www.google.be/search?q=" + URL);
        }



    }
}
