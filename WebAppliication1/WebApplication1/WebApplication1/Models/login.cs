using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class login
    {
         public int name { get; set; }
        public int pass { get; set; }

        public bool log()
        {
            SqlCommand sc = new SqlCommand("logg", connection.my_con());
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = sc.ExecuteReader();
            login l = new login();

            while (sdr.Read())
            {
                l.name = Convert.ToInt32((sdr["username"]).ToString());

                l.pass = Convert.ToInt32((sdr["pass"]).ToString());
                if (l.name==name && l.pass==pass)
                {
                    sdr.Close();
                    return true;
                }
                
            }

            sdr.Close();
            return false;
        }

    }
    }
