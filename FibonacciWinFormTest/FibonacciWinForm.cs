using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciWinFormTest
{
    /// <summary>
    /// Formulaire de fibonacci 10
    /// </summary>
    public partial class FibonacciWinForm : Form
    {
        public FibonacciWinForm()
        {
            InitializeComponent();
        }

        private async void fibonacciCompute_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string urlServer = "http://localhost:3000/";
            HttpClient client = new HttpClient();
            var reponseHttp = client.GetAsync(urlServer + "api/fibonacci/10").Result;
            await Task.Delay(3000);
            this.Enabled = true;
            this.Hide();
            MessageBox.Show("Valeur de la suite de fibonacci: " + reponseHttp.Content.ReadAsStringAsync().Result);
            this.Show();
        }
    }
}
