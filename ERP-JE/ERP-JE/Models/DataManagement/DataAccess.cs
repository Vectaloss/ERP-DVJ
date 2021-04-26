using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;



namespace ERP_JE.Models.DataManagement
{
    public class DataAcces
    {
        string ConnectionString = "";
        public List<Member> GetMembers()
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Member>("select * from Members").ToList();
            }
        }
        public void AddMember(Member m)
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`members` (`firstName`, `lastName`, `birth`, `email`) VALUES('{m.FirstName}','{m.LastName}','{m.Birth.Year}-{m.Birth.Month}-{m.Birth.Day}','{m.Email}')");
            }
        }
    }

    
    
}
