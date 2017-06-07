using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AcitoEcommerce.Models;

namespace AcitoEcommerce.DAL
{
    public class AcitoEcommerceContext: DbContext
    {
        public AcitoEcommerceContext() : base("AcitoEcommerce")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }
    }
}