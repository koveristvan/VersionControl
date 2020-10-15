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
using Webszolg.MnbServiceReference;

namespace Webszolg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MNBArfolyamServiceSoapClient mnbservice = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbservice.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }
    }
}
