using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Iemployees
    {
        int id { get; set; }
        string username { get; set; }
        string password { get; set; }
        string first_name { get; set; }
        string last_name { get; set; }
        int permId { get; set; }
        DateTime created { get; set; }
    }

    interface Iitems
    {
        int id { get; set; }
        string name { get; set; }
        int price { get; set; }
    }

    interface Iorders
    {
        int id { get; set; }
        int reservation_id { get; set; }
        int item_id { get; set; }
    }

    interface Ireservations
    {
        int id { get; set; }
        int employee_id { get; set; }
        int table_id { get; set; }
        DateTime start_date { get; set; }
        DateTime end_date { get; set; }
    }

    interface Itables
    {
        int id { get; set; }
        string name { get; set; }
        int seats { get; set; }
    }

    interface Ipermissions
    {
        int id { get; set; }
        string name { get; set; }
    }
}
