using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{
    public class CreditCardDAO : ICreditCardDAO
    {
        public CreditCardDTO GetRecordByID(string key)
        {
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            try
            {
                objConn.Open();
                string strSQL = "SELECT CREDITCARD.CreditCardNumber, " +
                "CREDITCARD.CreditCardOwnerName, " +
                "CREDITCARD.CreditCardProcessingMerchantServiceCompanyCode, " +
                "CREDITCARDPROCESSINGMERCHANTSERVICECOMPANY.CreditCardProcessingMerchantServiceCompanyName, " +
                "CREDITCARD.CreditCardNetworkCompanyCode, CREDITCARDNETWORKCOMPANY.CreditCardNetworkCompanyName, " +
                "CREDITCARD.CreditCardIssuingBankCode, CREDITCARDISSUINGBANK.CreditCardIssuingBankName,  " +
                "CREDITCARD.CreditCardCorporateMerchantBankCode, " +
                "CREDITCARDCORPORATEMERCHANTBANK.CreditCardCorporateMerchantBankName, " +
                "CREDITCARD.ExpDate, CREDITCARD.AddressLine1, CREDITCARD.AddressLine2, CREDITCARD.City, " +
                "CREDITCARD.StateCode, CREDITCARD.ZipCode, CREDITCARD.Country, " +
                "CREDITCARD.CreditCardLimit, CREDITCARD.CreditCardAvailableCredit, CREDITCARD.ActivationStatus " +
                "FROM CREDITCARD, CREDITCARDPROCESSINGMERCHANTSERVICECOMPANY, " +
                "CREDITCARDNETWORKCOMPANY, CREDITCARDISSUINGBANK, CREDITCARDCORPORATEMERCHANTBANK " +
                "WHERE CREDITCARD.CreditCardProcessingMerchantServiceCompanyCode = " +
                "CREDITCARDPROCESSINGMERCHANTSERVICECOMPANY.CreditCardProcessingMerchantServiceCompanyCode AND " +
                "CREDITCARD.CreditCardNetworkCompanyCode = CREDITCARDNETWORKCOMPANY.CreditCardNetworkCompanyCode AND " +
                "CREDITCARD. CreditCardIssuingBankCode = CREDITCARDISSUINGBANK.CreditCardIssuingBankCode AND " +
                "CREDITCARD.CreditCardCorporateMerchantBankCode = CREDITCARDCORPORATEMERCHANTBANK.CreditCardCorporateMerchantBankCode AND " +
                "CREDITCARD.CreditCardNumber = @CreditCardNumber;";
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                objCmd.CommandType = CommandType.Text;
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;
                SqlDataReader objDR = objCmd.ExecuteReader();

                if (objDR.HasRows)
                {
                    CreditCardDTO objDTO = new CreditCardDTO();
                    objDR.Read();
                    objDTO.CreditCardNumber = objDR.GetString(0);
                    objDTO.CreditCardOwnerName = objDR.GetString(1);
                    objDTO.CreditCardProcessingMerchantServiceCompanyCode = objDR.GetByte(2);
                    objDTO.CreditCardProcessingMerchantServiceCompanyName = objDR.GetString(3);
                    objDTO.CreditCardNetworkCompanyCode = objDR.GetByte(4);
                    objDTO.CreditCardNetworkCompanyName = objDR.GetString(5);
                    objDTO.CreditCardIssuingBankCode = objDR.GetByte(6);
                    objDTO.CreditCardIssuingBankName = objDR.GetString(7);
                    objDTO.CreditCardCorporateMerchantBankCode = objDR.GetByte(8);
                    objDTO.CreditCardCorporateMerchantBankName = objDR.GetString(9);
                    objDTO.ExpDate = objDR.GetDateTime(10);
                    objDTO.AddressLine1 = objDR.GetString(11);
                    objDTO.AddressLine2 = objDR.GetString(12);
                    objDTO.City = objDR.GetString(13);
                    objDTO.StateCode = objDR.GetString(14);
                    objDTO.ZipCode = objDR.GetString(15);
                    objDTO.Country = objDR.GetString(16);
                    objDTO.CreditCardLimit = objDR.GetDecimal(17);
                    objDTO.CreditCardAvailableCredit = objDR.GetDecimal(18);
                    objDTO.CreditCardActivationStatus = objDR.GetBoolean(19);

                    objDR.Close();
                    objCmd.Dispose();
                    return objDTO;
                }
                else
                {
                    objDR.Close();
                    objCmd.Dispose();
                    return null;
                }
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in CreditCardADO GetRecordByID(key) Method: " + objE.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objConn = null;

            }
        }
    }
}
