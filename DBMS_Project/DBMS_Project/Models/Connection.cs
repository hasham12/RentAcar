using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
namespace DBMS_Project.Models
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("data source=localhost; initial catalog; carProject; Integrated Security = True");
        }
    }
}