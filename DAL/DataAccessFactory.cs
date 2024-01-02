using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
       
        public static IRepo<Product, int, Product> ProductDataAccess()
        
        { return new ProductRepo(); }
       
        public static IActiveUser<User, string, User> UserDataAccess()
        { 
            return new UserRepo();
        }
        public static IRepo<TrackOrder, int, TrackOrder> TrackOrderDataAccess()
        { 
            return new TrackOrderRepo();
        }
        public static IRepo<Payment, int, Payment> PaymentDataAccess()
        { 
            return new PaymentRepo();
        }
       
        public static IRepo<ProductInventory, int, ProductInventory> ProductInventoryDataAccess() 
        { 
            return new ProductInventoryRepo(); 
        }
       
    }
}