using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
    public partial class Rental
    {
        public System.DateTime CheckInDay { get; set; }
        public System.DateTime CheckOutDay { get; set; }
        public int CustomerID { get; set; }
        public int DriverID { get; set; }
        public int LocationID { get; set; }
        public int CarId { get; set; }
        public void InsertRental()
        {
            SqlCommand commandar = new SqlCommand();
            commandar.Connection = Connection.GetConnection();
            commandar.Connection.Open();
            commandar.Prepare();
            commandar.CommandText = "INSERT INTO Rental (CustomerID, DriverID, LocationID, CarId, CheckInDay, CheckOutDay) Values (?,?,?,?,?,?) ";
            commandar.Parameters.Add(CustomerID);
            commandar.Parameters.Add(DriverID);
            commandar.Parameters.Add(LocationID);
            commandar.Parameters.Add(CarId);
            commandar.Parameters.Add(CheckInDay);
            commandar.Parameters.Add(CheckOutDay);
            commandar.ExecuteNonQuery();
            commandar.Connection.Close();
        }
        public List<Rental> GetRentals(int CustomerID = -1, int DriverID = -1, int LocationID = -1, int CarID = -1)
        {
            string QueryBuilder = "SELECT * FROM Rental Where 1=1 ";
            if (CustomerID >= 0)
                QueryBuilder += " AND CustomerID = " + CustomerID;
            if (DriverID >= 0)
                QueryBuilder += " AND DriverID = " + DriverID;
            if (LocationID >= 0)
                QueryBuilder += " AND LocationID = " + LocationID;
            if (CarID >= 0)
                QueryBuilder += " AND CarID = " + LocationID;
            SqlCommand commandar = new SqlCommand();
            commandar.CommandText = QueryBuilder;
            commandar.Connection = Connection.GetConnection();
            commandar.Connection.Open();
            SqlDataReader dataReceived = commandar.ExecuteReader();
            List<Rental> h = new List<Rental>();
            while (dataReceived.Read())
            {
                Rental obj = new Rental();
                obj.CarId = (int)dataReceived["CarId"];
                obj.CheckInDay = (DateTime)dataReceived["CheckInDay"];
                obj.CheckOutDay = (DateTime)dataReceived["CheckOutDay"];
                obj.CustomerID = (int)dataReceived["CustomerID"];
                obj.DriverID = (int)dataReceived["DriverID"];
                obj.LocationID = (int)dataReceived["LocationID"];
                h.Add(obj);
            }
            commandar.Connection.Close();
            return h;
        }
    }
}