using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{
    public abstract class DALObjectFactoryBase
    {
        public const int SQLSERVER = 1;
        public const int ORACLE = 2;
        public const int MYSQL = 3;

        // Static method to get the specific DBMS factory
        public static DALObjectFactoryBase GetDataSourceDAOFactory(int targetDataSourceFactory)
        {
            switch (targetDataSourceFactory)
            {
                case 1:
                    return new SQLServerDAOFactory();
                case 2:
                    throw new NotImplementedException();

                case 3:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentException("Invalid Factory Selection");
            }
        }

        // Abstract methods that derived factories must implement
        public abstract CreditCardDAO GetCreditCardDAO();
    }
}
