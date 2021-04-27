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
        public Customers GetCustomerBySIREN(int SIREN)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.QueryFirst<Customers>("select * from Customers where SIREN = "+SIREN+";");
            }
        }
        public List<Customers> GetCustomers()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Customers>("select * from Customers").ToList();
            }
        }
        public Customers GetCustomer(int IdCustomer)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.QueryFirst<Customers>("select * from Customers where IdCustomer = "+IdCustomer);
            }
        }
        public List<Contacts> GetContacts (int IdCustomer)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Contacts>("select * from Contacts where idCustomer = "+ IdCustomer).ToList();
            }
        }
        public void AddMember(Member m)
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`members` (`firstName`, `lastName`, `birth`, `email`) VALUES ('{m.FirstName}','{m.LastName}','{m.Birth.Year}-{m.Birth.Month}-{m.Birth.Day}','{m.Email}')");
            }
        }
        public void AddCustomer(Customers c)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`Customers` (`name`,`idAdress`,`SIREN`,`sector`,`website`,`size`)" +
                                                           $"VALUES('{c.Name}','{c.IdAdress}','{c.SIREN}','{c.Sector}','{c.Website}','{c.Size}')");
            }
        }
        public void AddContact(Contacts c)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`Contacts` (`lastName`,`firstName`, `origin`,`job`,`phone`, `email`,`commentary`,`Idcustomer`)" +
                                                           $" VALUES('{c.LastName}','{c.FirstName}','{c.Origin}','{c.Job}','{c.Phone}','{c.Email}','{c.Commentary}','{c.IdCustomer}')");
            }
        }

    }

    
    
}
