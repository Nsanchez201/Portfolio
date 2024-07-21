using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class CreditCard
    {

        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private byte m_creditCardProcessingMerchantServiceCompanyCode;
        private string m_creditCardProcessingMerchantServiceCompanyName;
        private byte m_creditCardNetworkCompanyCode;
        private string m_creditCardNetworkCompanyName;
        private byte m_creditCardIssuingBankCode;
        private string m_creditCardIssuingBankName;
        private byte m_creditCardCorporateMerchantBankCode;
        private string m_creditCardCorporateMerchantBankName;
        private DateTime m_expDate;
        private string m_addressLine1;
        private string m_addressLine2;
        private string m_city;
        private string m_state;
        private string m_zipCode;
        private string m_country;
        private decimal m_creditCardLimit;
        private decimal m_creditCardAvailableCredit;
        private bool m_creditCardActivationStatus;

        public CreditCard()
        {
            m_CreditCardNumber = "";
            m_CreditCardOwnerName = "";
            m_creditCardProcessingMerchantServiceCompanyCode = 0;
            m_creditCardProcessingMerchantServiceCompanyName = "";
            m_creditCardNetworkCompanyCode = 0;
            m_creditCardNetworkCompanyName = "";
            m_creditCardIssuingBankCode = 0;
            m_creditCardIssuingBankName = "";
            m_creditCardCorporateMerchantBankCode = 0;
            m_creditCardCorporateMerchantBankName = "";
            m_expDate = new DateTime().Date;
            m_addressLine1 = "";
            m_addressLine2 = "";
            m_city = "";
            m_state = "";
            m_zipCode = "";
            m_country = "";
            m_creditCardLimit = 0;
            m_creditCardAvailableCredit = 0;
            m_creditCardActivationStatus = false;
        }

        public CreditCard(string creditCardNumber, string creditCardOwnerName, byte creditCardProcessingMerchantServiceCompanyCode, string creditCardProcessingMerchantServiceCompanyName, byte creditCardNetworkCompanyCode, string creditCardNetworkCompanyName, byte creditCardIssuingBankCode, string creditCardIssuingBankName, byte creditCardCorporateMerchantBankCode, string creditCardCorporateMerchantBankName, DateTime expDate, string addressLine1, string addressLine2, string city, string state, string zipCode, string country, decimal creditCardLimit, decimal creditCardAvailableCredit, bool creditCardActivationStatus)
        {
            this.m_CreditCardNumber = creditCardNumber;
            this.m_CreditCardOwnerName = creditCardOwnerName;
            this.m_creditCardProcessingMerchantServiceCompanyCode = creditCardProcessingMerchantServiceCompanyCode;
            this.m_creditCardProcessingMerchantServiceCompanyName = creditCardProcessingMerchantServiceCompanyName;
            this.m_creditCardNetworkCompanyCode = creditCardNetworkCompanyCode;
            this.m_creditCardNetworkCompanyName = creditCardNetworkCompanyName;
            this.m_creditCardIssuingBankCode = creditCardIssuingBankCode;
            this.m_creditCardIssuingBankName = creditCardIssuingBankName;
            this.m_creditCardCorporateMerchantBankCode = creditCardCorporateMerchantBankCode;
            this.m_creditCardCorporateMerchantBankName = creditCardCorporateMerchantBankName;
            this.m_expDate = expDate;
            this.m_addressLine1 = addressLine1;
            this.m_addressLine2 = addressLine2;
            this.m_city = city;
            this.m_state = state;
            this.m_zipCode = zipCode;
            this.m_country = country;
            this.m_creditCardLimit = creditCardLimit;
            this.m_creditCardAvailableCredit = creditCardAvailableCredit;
            this.m_creditCardActivationStatus = creditCardActivationStatus;
        }

        public string CreditCardNumber
        {
            get { return m_CreditCardNumber; }
            set { m_CreditCardNumber = value; }
        }

        public string CreditCardOwnerName
        {
            get { return m_CreditCardOwnerName; }
            set { m_CreditCardOwnerName = value; }
        }

        public byte CreditCardProcessingMerchantServiceCompanyCode
        {
            get { return m_creditCardProcessingMerchantServiceCompanyCode; }
            set { m_creditCardProcessingMerchantServiceCompanyCode = value; }
        }

        public string CreditCardProcessingMerchantServiceCompanyName
        {
            get { return m_creditCardProcessingMerchantServiceCompanyName; }
            set { m_creditCardProcessingMerchantServiceCompanyName = value; }
        }

        public byte CreditCardNetworkCompanyCode
        {
            get { return m_creditCardNetworkCompanyCode; }
            set { m_creditCardNetworkCompanyCode = value; }
        }

        public string CreditCardNetworkCompanyName
        {
            get { return m_creditCardNetworkCompanyName; }
            set { m_creditCardNetworkCompanyName = value; }
        }

        public byte CreditCardIssuingBankCode
        {
            get { return m_creditCardIssuingBankCode; }
            set { m_creditCardIssuingBankCode = value; }
        }

        public string CreditCardIssuingBankName
        {
            get { return m_creditCardIssuingBankName; }
            set { m_creditCardIssuingBankName = value; }
        }

        public byte CreditCardCorporateMerchantBankCode
        {
            get { return m_creditCardCorporateMerchantBankCode; }
            set { m_creditCardCorporateMerchantBankCode = value; }
        }

        public string CreditCardCorporateMerchantBankName
        {
            get { return m_creditCardCorporateMerchantBankName; }
            set { m_creditCardCorporateMerchantBankName = value; }
        }

        public DateTime ExpDate
        {
            get { return m_expDate; }
            set { m_expDate = value; }
        }

        public string AddressLine1
        {
            get { return m_addressLine1; }
            set { m_addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return m_addressLine2; }
            set { m_addressLine2 = value; }
        }

        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }

        public string State
        {
            get { return m_state; }
            set { m_state = value; }
        }

        public string ZipCode
        {
            get { return m_zipCode; }
            set { m_zipCode = value; }
        }

        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }

        public decimal CreditCardLimit
        {
            get { return m_creditCardLimit; }
            set { m_creditCardLimit = value; }
        }

        public decimal CreditCardAvailableCredit
        {
            get { return m_creditCardAvailableCredit; }
            set { m_creditCardAvailableCredit = value; }
        }

        public bool CreditCardActivationStatus
        {
            get { return m_creditCardActivationStatus; }
            set { m_creditCardActivationStatus = value; }
        }
        ~CreditCard() { }

        // Public Instance Methods
        public void Print()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Network_Printer.txt"))
                {
                    // Print credit card details
                    Console.WriteLine("Credit Card Number: " + CreditCardNumber);
                    Console.WriteLine("Credit Card Owner Name: " + CreditCardOwnerName);
                    Console.WriteLine("Expiration Date: " + ExpDate.ToString("MM/yyyy"));
                    Console.WriteLine("Credit Limit: " + CreditCardLimit);
                    Console.WriteLine("Available Credit: " + CreditCardAvailableCredit);
                    Console.WriteLine("Address: " + AddressLine1 + ", " + City + ", " + State + " " + ZipCode + ", " + Country);
                    Console.WriteLine("Processing Merchant Service Company Code: " + CreditCardProcessingMerchantServiceCompanyCode);
                    Console.WriteLine("Processing Merchant Service Company Name: " + CreditCardProcessingMerchantServiceCompanyName);
                    Console.WriteLine("Network Company Code: " + CreditCardNetworkCompanyCode);
                    Console.WriteLine("Network Company Name: " + CreditCardNetworkCompanyName);
                    Console.WriteLine("Issuing Bank Code: " + CreditCardIssuingBankCode);
                    Console.WriteLine("Issuing Bank Name: " + CreditCardIssuingBankName);
                    Console.WriteLine("Corporate Merchant Bank Code: " + CreditCardCorporateMerchantBankCode);
                    Console.WriteLine("Corporate Merchant Bank Name: " + CreditCardCorporateMerchantBankName);

                    // Check if credit limit is exceeded
                    if (CreditCardAvailableCredit < 0)
                    {
                        throw new Exception("Credit limit exceeded.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }
        public bool Activate()
        {
            // Set the activation status to true
            CreditCardActivationStatus = true;
            CreditCardActivationStatus = true;
            // Return the activation status
            return CreditCardActivationStatus;
        }
        public bool Deactivate()
        {
            // Set the activation status to false
            CreditCardActivationStatus = false;
            // Return the activation status
            return CreditCardActivationStatus;
        }

        // Public Instance & Static Data Access Methods
        public bool Load(string key)
        {
            // Call the private DALayer_Load() method to load the object from the database
            bool success = DALayer_Load(key);
            // Return the result
            return success;
        }
        private bool DALayer_Load(string key)
        {

            //Step A-Start Error Trapping 
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY  
                //Data Access Object using POLYMORPHISM. 
                DALObjectFactoryBase objDAOFactory =DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object  
                //call the correct Data Access Object to perform the Data Access 
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objCreditCardDTO = ((ICreditCardDAO)objCreditCardDAO).GetRecordByID(key);

                //Step 4- test if DTO object exists & populate this object with DTO object's properties 
                //and return a true or return a False if no DTO object exists. 
                if (objCreditCardDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object 
                    this.CreditCardNumber = objCreditCardDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objCreditCardDTO.CreditCardOwnerName;
                    this.CreditCardProcessingMerchantServiceCompanyCode =objCreditCardDTO.CreditCardProcessingMerchantServiceCompanyCode;
                    this.CreditCardProcessingMerchantServiceCompanyName = objCreditCardDTO.CreditCardProcessingMerchantServiceCompanyName;
                    this.CreditCardNetworkCompanyCode = objCreditCardDTO.CreditCardNetworkCompanyCode;
                    this.CreditCardNetworkCompanyName = objCreditCardDTO.CreditCardNetworkCompanyName;
                    this.CreditCardIssuingBankCode = objCreditCardDTO.CreditCardIssuingBankCode;
                    this.CreditCardIssuingBankName = objCreditCardDTO.CreditCardIssuingBankName;
                    this.CreditCardCorporateMerchantBankCode = objCreditCardDTO.CreditCardCorporateMerchantBankCode;
                    this.CreditCardCorporateMerchantBankName = objCreditCardDTO.CreditCardCorporateMerchantBankName;
                    this.ExpDate = objCreditCardDTO.ExpDate;
                    this.AddressLine1 = objCreditCardDTO.AddressLine1;
                    this.AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.City = objCreditCardDTO.City;
                    this.State = objCreditCardDTO.StateCode;
                    this.ZipCode = objCreditCardDTO.ZipCode;
                    this.Country = objCreditCardDTO.Country;
                    this.CreditCardLimit = objCreditCardDTO.CreditCardLimit;
                    this.CreditCardAvailableCredit = objCreditCardDTO.CreditCardAvailableCredit;

                    //Handle activation status accordingly using methods 
                    //since ActivationStutus property is read only 
                    if (objCreditCardDTO.CreditCardActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    //Step 4c-Returns a true since this class object has been populated. 
                    return true;
                }
                else
                {
                    //Step 5- No object returned from DALayer, return a false 
                    return false;
                }
            }//End of try 
             //Step B-Traps for general exception.   
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions 
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method 
    }
}
