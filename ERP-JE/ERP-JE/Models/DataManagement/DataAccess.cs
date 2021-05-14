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
        string ConnectionString = "Server=localhost;Database=erp;Uid=root;Pwd=ICEtea@123";

        #region Members
        public void AddMember(Member m)
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`members` (`firstName`, `lastName`, `birth`, `email`) VALUES ('{m.FirstName}','{m.LastName}','{m.Birth.Year}-{m.Birth.Month}-{m.Birth.Day}','{m.Email}')");
            }
        }
        public List<Member> GetMembers()
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Member>("select * from Members").ToList();
            }
        }

        #endregion

        #region Customers
        public void AddCustomer(Customers c)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`Customers` (`name`,`idAdress`,`SIREN`,`sector`,`website`,`size`)" +
                                                           $"VALUES('{c.Name}','{c.IdAdress}','{c.SIREN}','{c.Sector}','{c.Website}','{c.Size}')");
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
        #endregion

        #region Contacts
        public void AddContact(Contacts c)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO `erp`.`Contacts` (`lastName`,`firstName`, `origin`,`job`,`phone`, `email`,`commentary`,`Idcustomer`)" +
                                                           $" VALUES('{c.LastName}','{c.FirstName}','{c.Origin}','{c.Job}','{c.Phone}','{c.Email}','{c.Commentary}','{c.IdCustomer}')");
            }
        }
        public List<Contacts> GetContacts (int IdCustomer)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Contacts>("select * from Contacts where idCustomer = "+ IdCustomer).ToList();
            }
        }
        #endregion

        #region Prospections
        public void AddProspection(Prospections p)
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO `erp`.`prospections` (`Needs`, `ConcernedBu`, `PreparationDate`, `type`, `firstApproachQuality`, `ContactDate`, `LeadedTo`, `Commentary`, `OpportunityOfImprovement`, `IdContact`, `IdUser`, `Status`) VALUES "
                    + $"('{p.Needs}','{p.ConcernedBu}','{p.PreparationDate.Year}-{p.PreparationDate.Month}-{p.PreparationDate.Day}','{p.type}','{p.firstApproachQuality}','{p.ContactDate.Year}-{p.ContactDate.Month}-{p.ContactDate.Day}','{p.LeadedTo}','{p.Commentary}','{p.OpportunityOfImprovement}','{p.IdContact}','{p.IdUser}','{p.Status}')");
            }
        }
        #endregion
        public List<Prospections> GetProspections()
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Prospections>("Select * from Prospections").ToList();
            }
        }
        public List<Prospections> GetProspectionsByUser(int IdUser)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.Query<Prospections>("Select * from Prospections where IdUser =" + IdUser).ToList();
            }
        }
    }



}
