﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class connection
    {
        public static SqlConnection con;

        public static SqlConnection my_con()
        {
            if (con == null)
            {
                con = new SqlConnection();
                con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["lab"].ToString();
                con.Open();
            }

            return con;
        }
    }
}