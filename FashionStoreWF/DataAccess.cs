using Dapper;
using FashionStoreWF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStoreWF
{
    public class DataAccess
    {

        public List<User> GetUsers()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var Users = con.Query<User>("select * from Users").ToList();
                return Users;
            }
        }

        public void AddUser(User user)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<User> users = new List<User>();
                users.Add(user);
                con.Execute("dbo.Users_Insert @email, @u_name, @e_password", users);
            }
        }

        public List<User> GetUser(string userName)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<User> Users = con.Query<User>($"select email, u_name, e_password from Users where u_name = '{ userName }'").ToList();
                if (Users.Count == 0)
                {
                    User us = new User();
                    us.e_password = "$MYHASH$V1$10000$wNN7i47ToXMLryAqVAX3M81wJvu5yMCpupTf9xlmYEGsqqwT";
                    Users.Add(us);
                }
                return Users;
            }
        }

        public void AddCustomer(Customer customer)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Customer> customers = new List<Customer>();
                customers.Add(customer);
                con.Execute("dbo.Customers_Insert @FirstName, @LastName, @email, @c_address", customers);
            }
        }

        public void AddSupplier(Supplier supplier)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Supplier> suppliers = new List<Supplier>();
                suppliers.Add(supplier);
                con.Execute("dbo.Suppliers_Insert @s_name, @email, @phone, @s_address", suppliers);
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(employee);
                con.Execute("dbo.Suppliers_Insert @s_name, @email, @phone, @s_address", employees);
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var customers = con.Query<Customer>("select * from Customers").ToList();
                return customers;
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var suppliers = con.Query<Supplier>("select * from Suppliers").ToList();
                return suppliers;
            }
        }

    }
}
