using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {        
        private ApplicationDbContext _context = null;

        public CustomerController()
        {
            _context = new ApplicationDbContext();            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        // GET: Customer
        public ActionResult Index()
        {
            try
            {
                var customers = _context.Customers.Include(c => c.MembershipType).ToList();                 
                return View(customers);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        // GET: Customer/1
        public ActionResult Details(int Id)
        {
            try
            {
                var customer = (from c in _context.Customers where c.Id == Id select c).Include(c => c.MembershipType).SingleOrDefault();
                return View(customer);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}