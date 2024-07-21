using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{// Concrete factory for SQL Server
    public class SQLServerDAOFactory : DALObjectFactoryBase
    {
        public static string ConnectionString()
        {
            return "Data Source =.\\SQLExpress; Initial Catalog = EZRENTAL; Integrated Security = True";

        }
        public override CreditCardDAO GetCreditCardDAO()
        {
            //return CreditCardDAO Data Access Object to perform CreditCard class Data Access
            return new CreditCardDAO();

        }


    }

    // Concrete factory for Oracle Server
    public class OracleServerDAOFactory : DALObjectFactoryBase
    {
        public override CreditCardDAO GetCreditCardDAO()
        {
            // Oracle-specific implementation would go here
            throw new NotImplementedException();
        }
    }

    // Concrete factory for MySQL Server
    public class MySQLServerDAOFactory : DALObjectFactoryBase
    {
        public override CreditCardDAO GetCreditCardDAO()
        {
            // MySQL-specific implementation would go here
            throw new NotImplementedException();
        }


    }
    }


