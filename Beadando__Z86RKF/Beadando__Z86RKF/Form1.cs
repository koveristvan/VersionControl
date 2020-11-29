using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando__Z86RKF
{
    public partial class Form1 : Form
    {

        ReaEstateEntities context = new ReaEstateEntities();
        public Form1()
        {
            InitializeComponent();

            context.Realestate.Load();

            rebindingsource.DataSource = context.Realestate.Local;

            dataGridView1.DataSource = rebindingsource;
        }
    }
}
