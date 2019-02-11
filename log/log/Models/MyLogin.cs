using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace log.Models
{
    public class login
    {
        public int name { get; set; }
        public int pass { get; set; }

        public bool log()
        {
            SqlCommand sc = new SqlCommand("logg", Connections.my_con());
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = sc.ExecuteReader();
            login l = new login();

            while (sdr.Read())
            {
                l.name = Convert.ToInt32((sdr["UserName"]).ToString());

                l.pass = Convert.ToInt32((sdr["Pass"]).ToString());
                if (l.name == name && l.pass == pass)
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