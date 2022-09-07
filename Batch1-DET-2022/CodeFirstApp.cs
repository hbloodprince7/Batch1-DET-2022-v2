using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirstApp
    {
        static void Main(string[] args)
        {
            //AddNewBook();
            //DeleteBook();
            //UpdateBook();
            //GetBooks();

            //AddNewOrder();

            //AddOrderForCust();
            //UpdateCustInfo();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();






















        }

        private static void AddNewOrder()
        {
            var ctx = new BookContext();
            Customer customer = new Customer();
            customer.ID = 7735;
            customer.Name = "Ben Ulrich";
            customer.Age = 62;
            Order ord = new Order();
            ord.Order_ID = 7501;
            ord.Amount = 9200;
            ord.OrderDate = DateTime.Now;

            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("New Order Added");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }
        private static void AddOrderForCust()
        {
            var ctx = new BookContext();
            
            var customer = ctx.Customers.Where(e => e.ID == 7735).SingleOrDefault();
            Order ord = new Order();
            ord.Order_ID = 85;
            ord.Amount = 725;
            ord.OrderDate = DateTime.Now;
            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine($"New Order Added for Customer - {customer.Name}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();
            var customer = ctx.Customers.Where(c => c.ID == 1378).SingleOrDefault();
            ctx.Dispose();
            UpdateCustomerName(customer);
        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike Jason";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR
            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");
        }





        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 2;
            book.BookName = "THOR #77";
            book.author = "Stan Lee";
            book.price = 60;

            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine($"Added {book.BookName} Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message) ;
            }
        }   
        private static void DeleteBook()
        {
            var ctx = new BookContext();
            var book = ctx.Books.Where(e => e.BookID == 73).SingleOrDefault();
            book.BookID = 73;
            book.BookName = "SPIDERMAN SPECIAL EDITION";


            try
            {
                ctx.Books.Remove(book);
                ctx.SaveChanges() ;
                Console.WriteLine($"Removed {book.BookName} Succesfully");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }
        }
        private static void UpdateBook()
        {
            var ctx = new BookContext();
            var book = ctx.Books.Where(e => e.BookID == 73).SingleOrDefault();
            book.BookID = 73;
            book.BookName = "SPIDERMAN SPECIAL EDITION";
            try
            {

                ctx.Update(book);
                ctx.SaveChanges();
                Console.WriteLine($"Updated {book.BookID}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void GetBooks()
        {
            var ctx = new BookContext();
            var book = ctx.Books;
            try
            {
                foreach (var b in book)
                    Console.WriteLine($"{b.BookName} by {b.author}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);                   



                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");




                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine("Order Amount:" + order.Amount.ToString() + " Order ID:" + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;



                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");



                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());



                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void UpdateCustInfo()
        {
            var ctx = new BookContext();
            var customer = ctx.Customers.Where(e => e.ID == 7735).SingleOrDefault();
            customer.ID = 7735;
            customer.Name = "Ben Urich";
            ctx.Customers.Update(customer);
            ctx.SaveChanges();
            Console.WriteLine("Updated Customer Mr. Urich");

        }
    }
}
