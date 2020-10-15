using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Webszolg.Entities;
using Webszolg.MnbServiceReference;

namespace Webszolg
{
    public partial class Form1 : Form
    {
        RichTextBox rtb1 = new RichTextBox();
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Currencies;

            RefreshData();
            
        }

        public void RefreshData()
        {
            Rates.Clear();
            dataGridView1.DataSource = Rates;
            
            getexchangerates();
            xmldata();
            addchart();

        }



        public void getexchangerates()
        {
            var mnbservice = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = dateTimePicker1.Value.ToString(),
                endDate = dateTimePicker2.Value.ToString(),
            };

            var response = mnbservice.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            rtb1.Text = result;
     
        }


        public void xmldata()
        {
            var xml = new XmlDocument();
            xml.LoadXml(rtb1.Text.ToString());

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);


                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childelement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childelement.GetAttribute("curr");

                var unit = decimal.Parse(childelement.GetAttribute("unit"));
                var value = decimal.Parse(childelement.InnerText);
                if (unit!=0)
                {
                    rate.Value = value / unit;
                }
            }
        }

        public void addchart() 
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartarea = chartRateData.ChartAreas[0];
            chartarea.AxisX.MajorGrid.Enabled = false;
            chartarea.AxisY.MajorGrid.Enabled = false;
            chartarea.AxisY.IsStartedFromZero = false;
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
