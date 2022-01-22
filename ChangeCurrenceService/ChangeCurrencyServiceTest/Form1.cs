using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangeCurrencyServiceTest.ServiceReference1;


namespace ChangeCurrencyServiceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            CaculateServiceClient client = new CaculateServiceClient();
            
            Int32 enterAmount = Convert.ToInt32(txtInput.Text.Trim());

            


            if (cboActionType.Text == "USD")
            {
                txtResult.Text = client.Change(enterAmount, 23260).ToString("#,##0");
               


            }
            if (cboActionType.Text == "EUR")
            {
                txtResult.Text = client.Change(enterAmount, 27061).ToString("#,##0");

            }
            if (cboActionType.Text == "AUD")
            {
                txtResult.Text = client.Change(enterAmount, 16798).ToString("#,##0");

            }
            if (cboActionType.Text == "JPY")
            {
                txtResult.Text = client.Change(enterAmount, 20704).ToString("#,##0");

            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
