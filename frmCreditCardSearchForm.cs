using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMSBOLayer;

namespace ARMSWinClient
{
    public partial class frmCreditCardSearchForm : Form
    {
        CreditCard objCreditCard;
        public frmCreditCardSearchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void frmCreditCardSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                objCreditCard = new CreditCard();
                string creditCardNumber = txtCreditCardNumber.Text;
                bool isLoaded = objCreditCard.Load(creditCardNumber);
                if (isLoaded)
                {
                    CreditCardOwnerName.Text = objCreditCard.CreditCardOwnerName;
                    txtExpirationDate.Text = objCreditCard.ExpDate.ToString("MM/yyyy");
                    txtCVV.Text = objCreditCard.CreditCardNumber; // Assuming CVV is a part of CreditCardNumber
                    txtMerchantServiceCompanyName.Text = objCreditCard.CreditCardProcessingMerchantServiceCompanyName;
                    txtNetworkCompanyName.Text = objCreditCard.CreditCardNetworkCompanyName;
                    txtIssuingBankName.Text = objCreditCard.CreditCardIssuingBankName;
                    txtCorporateMerchantBankName.Text = objCreditCard.CreditCardCorporateMerchantBankName;
                    txtAddressLine1.Text = objCreditCard.AddressLine1;
                    txtAddressLine2.Text = objCreditCard.AddressLine2;
                    txtCity.Text = objCreditCard.City;
                    txtState.Text = objCreditCard.State;
                    txtZipCode.Text = objCreditCard.ZipCode;
                    txtCountry.Text = objCreditCard.Country;
                    txtCreditLimit.Text = objCreditCard.CreditCardLimit.ToString();
                    txtAvailableCredit.Text = objCreditCard.CreditCardAvailableCredit.ToString();
                    chkActivationStatus.Checked = objCreditCard.CreditCardActivationStatus;
                }
                else
                {
                    MessageBox.Show("Credit card record not found.");
                    CreditCardOwnerName.Clear();
                    txtExpirationDate.Clear();
                    txtCVV.Clear();
                    txtMerchantServiceCompanyName.Clear();
                    txtNetworkCompanyName.Clear();
                    txtIssuingBankName.Clear();
                    txtCorporateMerchantBankName.Clear();
                    txtAddressLine1.Clear();
                    txtAddressLine2.Clear();
                    txtCity.Clear();
                    txtState.Clear();
                    txtZipCode.Clear();
                    txtCountry.Clear();
                    txtCreditLimit.Clear();
                    txtAvailableCredit.Clear();
                    chkActivationStatus.Checked = false;

                }
            }





            catch (System.Exception)
            {
                MessageBox.Show("Error in search!");

            }








        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCreditCard != null)
                {
                    objCreditCard.Print();
                    MessageBox.Show("Information sent to the printer.");
                }
                else
                {
                    MessageBox.Show("You need to search first before printing.");
                }
            }
            catch
            {
                MessageBox.Show("Error in Print!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CreditCardOwnerName.Clear();
            txtExpirationDate.Clear();
            txtCVV.Clear();
            txtMerchantServiceCompanyName.Clear();
            txtNetworkCompanyName.Clear();
            txtIssuingBankName.Clear();
            txtCorporateMerchantBankName.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipCode.Clear();
            txtCountry.Clear();
            txtCreditLimit.Clear();
            txtAvailableCredit.Clear();
            chkActivationStatus.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
