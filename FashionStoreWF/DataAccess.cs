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
                con.Execute("dbo.Employees_Insert @e_name, @nic, @e_address, @e_contactNumber, @e_jobrole", employees);
            }
        }

        public void AddItem(Item item)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Item> Items = new List<Item>();
                Items.Add(item);
                con.Execute("dbo.Items_Insert @itemCode, @itemName, @itemType, @itemDes", Items);
            }
        }

        public void AddPattern(Pattern pattern)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Pattern> patterns = new List<Pattern>();
                patterns.Add(pattern);
                con.Execute("dbo.Patterns_Insert @p_boardNumber, @p_date, @p_image", patterns);
            }
        }

        public void AddFinishGood(FinishGoods finishGood)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<FinishGoods> goods = new List<FinishGoods>();
                goods.Add(finishGood);
                con.Execute("dbo.FinishGoods_Insert @f_styleNum, @f_num, @f_image", goods);
            }
        }

        public void AddAttendance(Attendance attendance)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Attendance> list = new List<Attendance>();
                list.Add(attendance);
                con.Execute("dbo.Attendance_Insert @e_id, @e_name, @a_date", list);
            }
        }

        public void AddPayment(Payment payment)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                List<Payment> payments = new List<Payment>();
                payments.Add(payment);
                con.Execute("dbo.Payments_Insert @p_invoiceNum, @p_amount, @p_paidBy, @p_paidTo, @p_bank", payments);
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

        public List<Employee> GetAllEmployees()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var Employees = con.Query<Employee>("select * from Employees").ToList();
                return Employees;
            }
        }

        //ItemType.Items.Add("Raw Materials");
        //ItemType.Items.Add("Finished Goods");
        public List<Item> GetItems(string type)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var Items = con.Query<Item>($"select * from Items where itemType = '{ type }'").ToList();
                return Items;
            }
        }

        public List<Attendance> GetAttendance()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var all = con.Query<Attendance>($"select * from Attendance").ToList();
                return all;
            }
        }

        public List<Payment> GetPayments()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var payments = con.Query<Payment>($"select * from Payments").ToList();
                return payments;
            }
        }

        public List<FinishGoods> GetFinishGoods() 
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var goods = con.Query<FinishGoods>($"select * from FinishGoods").ToList();
                return goods;
            }
        }

        public List<Pattern> GetAllPatterns()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConVal("fashionDB")))
            {
                var patterns = con.Query<Pattern>($"select * from Patterns").ToList();
                return patterns;
            }
        }
    }
}
