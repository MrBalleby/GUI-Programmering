using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BuisnessLogicLayer
    {
        public DataLayer dal = new DataLayer();


        public void C_Employee(string a, string b, string c, string d, string e, int f, DateTime g, string h)
        {
            dal.C_Employee(a,b,c,d,e,f,g,h);
        }
        public DataTable R_Employee(string a, string b)
        {
            DataTable dt = new DataTable();
            dt = dal.R_Employee(a, b);
            return dt;

        }
        public void U_Employee(int id, string a, string b, string c, string d, string e, int f, DateTime g, string h)
        {
            dal.U_Employee(id, a, b, c, d, e, f, g, h);
        }


        public void D_Employee(int a, string b)
        {
            dal.D_Employee(a, b);
        }

        public void C_Items(string a, int b, string c)
        {
            dal.C_Items(a, b, c);
        }

        public DataTable R_Items(string a, string b)
        {
            DataTable dt = new DataTable();
            dt = dal.R_Items(a, b);
            return dt;

        }

        public void U_Items(int id, string a, int b, string c)
        {
            dal.U_Items(id, a, b, c);
        }

        public void D_Items(int id, string a)
        {
            dal.D_Items(id, a);
        }


        public void C_Orders(int a, int b, string c)
        {
            dal.C_Orders(a, b, c);
        }

        public DataTable R_Orders(int id, string a)
        {
            DataTable dt = new DataTable();
            dt = dal.R_Orders(id, a);
            return dt;

        }

        public void U_Orders(int id, string a, int b, string c)
        {
            dal.U_Items(id, a, b, c);
        }

        public void D_Orders(int id, string a)
        {
            dal.D_Orders(id, a);
        }

        public void C_Permission(string a, string b)
        {
            dal.C_Permissions(a, b);
        }

        public DataTable R_Permissions(string a, string b)
        {
            DataTable dt = new DataTable();
            dt = dal.R_Permissions(a, b);
            return dt;

        }

        public void U_Permissions(int id, string a, string b)
        {
            dal.U_Permissions(id, a, b);
        }

        public void D_Permissions(int id, string a)
        {
            dal.D_Permissions(id, a);
        }

        public void C_Reservations(int a, int b, DateTime c, DateTime d, string e)
        {
            dal.C_Reservations(a, b, c, d, e);
        }

        public DataTable R_Reservations(int a, string b)
        {
            DataTable dt = new DataTable();
            dt = dal.R_Reservations(a, b);
            return dt;

        }

        public void U_Reservations(int id, int a, int b, DateTime c, DateTime d, string e)
        {
            dal.U_Reservations(id, a, b, c, d, e);
        }

        public void D_Reservations(int id, string a)
        {
            dal.D_Reservations(id, a);
        }

        public void C_Tables(string a, int b, string c)
        {
            dal.C_Tables(a, b, c);
        }

        public DataTable R_Tables(string a, string b)
        {
            DataTable dt = new DataTable();
            dt = dal.R_Tables(a, b);
            return dt;

        }

        public void U_Tables(int id, string a, int b, string c)
        {
            dal.U_Tables(id, a, b, c);
        }

        public void D_Tables(int id, string a)
        {
            dal.D_Tables(id, a);
        }




    }
}
