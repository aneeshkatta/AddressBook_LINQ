using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    internal class AddressBookManagemant
    {
        public static void AddDataToTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("first_name");
            table.Columns.Add("last_name");
            table.Columns.Add("address");
            table.Columns.Add("city");
            table.Columns.Add("state");
            table.Columns.Add("zip");
            table.Columns.Add("phone_number");
            table.Columns.Add("email");
            table.Rows.Add("ravi","k","hyderbad","Ts", "500001","987654321","kr@gmail.com");
            table.Rows.Add("raj","k","hyderbad","Ts", "500001", "987654321", "rk@gmail.com");
            table.Rows.Add("vani","k","mumbai","Maharastra","400001","9879974321","vk@gmail.com");
            table.Rows.Add("ramya","k","hyderbad","Ts", "500001","987654321","rkk@gmail.com");
            table.Rows.Add("rajan","k","mumbai","Maharastra","400001","987658321", "rkk@gmail.com");
            table.Rows.Add("rajender","k","hyderbad","Ts", "500001", "987654321", "rkk@gmail.com");
            DisplayTable(table);
        }
        public static void DisplayTable(DataTable table)
        {

            var first_name = from products in table.AsEnumerable() select products.Field<string>("first_name");
            var last_name = from products in table.AsEnumerable() select products.Field<string>("last_name");
            var address = from products in table.AsEnumerable() select products.Field<string>("address");
            var state = from products in table.AsEnumerable() select products.Field<string>("state");
            var zip = from products in table.AsEnumerable() select products.Field<string>("zip");
            var phone_number = from products in table.AsEnumerable() select products.Field<string>("phone_number");
            var email = from products in table.AsEnumerable() select products.Field<string>("email");

            // For each table in the DataSet, print the values of each row.

            DataRow[] rows = table.Select();

            // Print the value one column of each DataRow.
            for (int i = 0; i < rows.Length; i++)
            {
                if (i == 0)//for header
                {
                    Console.WriteLine("first_name" + " " + "last_name" + " " + "address" + " " + "state" + " " + "zip" + " " + "phone_number" + "email");
                }
                Console.WriteLine(rows[i]["first_name"]+" "+rows[i]["last_name"]+" "+rows[i]["address"]+" "+rows[i]["state"]+" "+rows[i]["zip"]+" "+rows[i]["phone_number"]+rows[i]["email"]+"\n");
            }
        }
    }
    
}
