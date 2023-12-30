using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace testUI02
{
    public class DataAccess
    {
        public List<Person> GetPeople(string last_name) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BikeStores")))
            {
                var output = connection.Query<Person>("dbo.GetPeopleByLastName @LastName", new {LastName = last_name}).ToList();
                // var output = connection.Query<Person>($"Select * from BikeStores.sales.customers where last_name = '{last_name}'").ToList();
                return output;
            }
        

        }
    }
}
