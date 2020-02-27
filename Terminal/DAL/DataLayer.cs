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
        public DateTime start_date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime end_date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //C
        public void C_Employee(string a, string b, string c, string d, string e, int f, DateTime g, string h)
        {
            string commandText = "insert into employees(username, password, first_name, last_name, email, permId, created) VALUES(@a, @b, @c, @d, @e, @f, @g)";

            using (SqlConnection connection = new SqlConnection(h))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@b", SqlDbType.VarChar);
                command.Parameters.Add("@c", SqlDbType.VarChar);
                command.Parameters.Add("@d", SqlDbType.VarChar);
                command.Parameters.Add("@e", SqlDbType.Int);
                command.Parameters.Add("@f", SqlDbType.DateTime);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@c", c);
                command.Parameters.AddWithValue("@d", d);
                command.Parameters.AddWithValue("@e", e);
                command.Parameters.AddWithValue("@f", f);
                command.Parameters.AddWithValue("@g", g);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void C_Items(string a, int b, string c)
        {
            string commandText = "insert into items(name, price) VALUES(@a, @b)";

            using (SqlConnection connection = new SqlConnection(c))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void C_Orders(int a, int b, string c)
        {
            string commandText = "insert into orders(reservation_id, item_id) VALUES(@a, @b)";

            using (SqlConnection connection = new SqlConnection(c))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.Int);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void C_Permissions(string a, string b)
        {
            string commandText = "insert into permissions(name, price) VALUES(@a)";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void C_Reservations(int a, int b, DateTime c, DateTime d, string e)
        {
            string commandText = "insert into reservations(employee_id, table_id, start_date, end_date) VALUES(@a, @b, @c)";

            using (SqlConnection connection = new SqlConnection(e))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.Int);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.Add("@c", SqlDbType.DateTime);
                command.Parameters.Add("@d", SqlDbType.DateTime);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@c", c);
                command.Parameters.AddWithValue("@c", d);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void C_Tables(string a, int b, string c)
        {
            string commandText = "insert into tables(name, seats) VALUES(@a, @b)";

            using (SqlConnection connection = new SqlConnection(c))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //R

        public DataTable R_Employee(string a, string b)
        {
            string commandText = "select username, first_name, last_name, email from employees where username = @a";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dt = sdr.GetSchemaTable();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public DataTable R_Items(string a, string b)
        {
            string commandText = "select * from items where name = @a";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dt = sdr.GetSchemaTable();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public DataTable R_Orders(int a, string b)
        {
            string commandText = "select * from orders where id = @a";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dt = sdr.GetSchemaTable();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public DataTable R_Permissions(string a, string b)
        {
            string commandText = "select * from permissions where name = @a";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dt = sdr.GetSchemaTable();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public DataTable R_Reservations(int a, string b)
        {
            string commandText = "select * from reservations where table_id = @a";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dt = sdr.GetSchemaTable();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public DataTable R_Tables(string a, string b)
        {
            string commandText = "select * from tables where name = @a";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.AddWithValue("@a", a);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dt = sdr.GetSchemaTable();
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        //U

        public void U_Employee(int id, string a, string b, string c, string d, string e, int f, DateTime g, string h)
        {
            string commandText = "update employees set username = @a, password = @b, first_name = @c, last_name = @d, email = @e, permId = @f, created = @g where id = @id";

            using (SqlConnection connection = new SqlConnection(h))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@b", SqlDbType.VarChar);
                command.Parameters.Add("@c", SqlDbType.VarChar);
                command.Parameters.Add("@d", SqlDbType.VarChar);
                command.Parameters.Add("@e", SqlDbType.Int);
                command.Parameters.Add("@f", SqlDbType.DateTime);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@c", c);
                command.Parameters.AddWithValue("@d", d);
                command.Parameters.AddWithValue("@e", e);
                command.Parameters.AddWithValue("@f", f);
                command.Parameters.AddWithValue("@g", g);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void U_Items(int id, string a, int b, string c)
        {
            string commandText = "update items set name = @a, price = @b where id = @id";

            using (SqlConnection connection = new SqlConnection(c))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void U_Orders(int id, int a, int b, string c)
        {
            string commandText = "update orders set reservation_id = @a, item_id = @b where id = @id";

            using (SqlConnection connection = new SqlConnection(c))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.Int);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void U_Permissions(int id, string a, string b)
        {
            string commandText = "update permissions set name = @a where id = @id";

            using (SqlConnection connection = new SqlConnection(b))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void U_Reservations(int id, int a, int b, DateTime c, DateTime d, string e)
        {
            string commandText = "update reservations set employee_id = @a, table_id = @b, start_date = @c, end_date = @d where id = @id";

            using (SqlConnection connection = new SqlConnection(e))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.Int);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.Add("@c", SqlDbType.DateTime);
                command.Parameters.Add("@d", SqlDbType.DateTime);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@c", c);
                command.Parameters.AddWithValue("@d", d);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void U_Tables(int id, string a, int b, string c)
        {
            string commandText = "update tables set name = @a, seats = @b where id = @id";

            using (SqlConnection connection = new SqlConnection(c))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@a", SqlDbType.VarChar);
                command.Parameters.Add("@b", SqlDbType.Int);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



        //D


        public void D_Employee(int id, string a)
        {
            string commandText = "delete from employees where id = @id";

            using (SqlConnection connection = new SqlConnection(a))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void D_Items(int id, string a)
        {
            string commandText = "delete from items where id = @id";

            using (SqlConnection connection = new SqlConnection(a))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void D_Orders(int id, string a)
        {
            string commandText = "delete from orders where id = @id";

            using (SqlConnection connection = new SqlConnection(a))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void D_Permissions(int id, string a)
        {
            string commandText = "delete from permissions where id = @id";

            using (SqlConnection connection = new SqlConnection(a))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void D_Reservations(int id, string a)
        {
            string commandText = "delete from reservations where id = @id";

            using (SqlConnection connection = new SqlConnection(a))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void D_Tables(int id, string a)
        {
            string commandText = "delete from tables where id = @id";

            using (SqlConnection connection = new SqlConnection(a))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
