using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DataLayer : Iemployees, Iitems, Iorders, Ipermissions, Ireservations, Itables
    {
        private string conn = "server=192.168.132.33;user id=db_user;database=restaurant;persistsecurityinfo=True";

        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string first_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string last_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int permId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int reservation_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int item_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int employee_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int table_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int seats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime created { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SQLString(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.ExecuteNonQuery();

        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //CRUD







    }
}
