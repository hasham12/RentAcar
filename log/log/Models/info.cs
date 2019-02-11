using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace log.Models
{
    public class info
    {
        public int id { get; set; }

        public string name { get; set; }

        public string fname { get; set; }

        //    public string addr { get; set; }


        public bool verify()
        {
            SqlCommand sc = new SqlCommand("ad", Connections.my_con());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@StudentName", name);
            sc.Parameters.AddWithValue("@FatherName", fname);

            SqlDataReader sdr = sc.ExecuteReader();
            sdr.Close();
            return true;
        }

        public bool verify2()
        {
            SqlCommand sc = new SqlCommand("del", Connections.my_con());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@StudentID", id);
            SqlDataReader sdr = sc.ExecuteReader();
            sdr.Close();
            return true;
        }

        public List<info> verify3()
        {
            List<info> abc = new List<info>();


            SqlCommand sc = new SqlCommand("Show", Connections.my_con());
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = sc.ExecuteReader();
            while (sdr.Read())
            {
                info i = new info();
                i.name = sdr["StudentName"].ToString();
                i.fname = sdr["FatherName"].ToString();
                //   i.addr = sdr["Address"].ToString();
                abc.Add(i);
            }
            sdr.Close();
            return abc;

        }
    }
}