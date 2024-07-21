using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSWinClient
{
    public partial class frmERPSystemForm : Form
    {
        public frmERPSystemForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBehicleInventoryMS_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditCardMS_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm objCCMSF = new frmCreditCardMSForm();
            this.Hide();
            objCCMSF.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
