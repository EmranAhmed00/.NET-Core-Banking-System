using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBanking.Models;
using OnlineBanking.ViewModels;
using PagedList;
using PagedList.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineBanking.Controllers
{
    public class CustomerController : Controller
    {

        private BankAppDataContext _context;

        public CustomerController(BankAppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Statistics()
        {
            var model = new StatisticsViewModel();

            model.NumberOfCustomers = _context.Customers.Count();
            model.NumberOfAccounts = _context.Accounts.Count();
            model.TotalBalance = _context.Accounts.Sum(n => n.Balance);
            return View(model);
        }


        //Customer Information 

            [HttpGet]
        public IActionResult CustomerInformation(int id )
        {
            var model = new CustomerInformationViewModel();

            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
            var dispositions = _context.Dispositions.Where(d => d.Customer == customer).ToList();
            var list = new List<Accounts>();
            foreach (var disposition in dispositions)
            {
                var account = _context.Accounts.SingleOrDefault(a => a.AccountId == disposition.AccountId); list.Add(account);
            }


         model.totalBalance =    list.Sum(k=> k.Balance);
          

            model.customerInfo = customer;
            model.accountInfo = list;
            return View(model);
        }


        [HttpGet]
        public IActionResult SearchCustomer()
        {
            return View(new CustomerInformationViewModel());
        }

        [HttpGet]
        public IActionResult SearchCustomer2(string search, string nam , string city , int page)
        {

            List<Customers> list = _context.Customers.Where(m => m.City == search).ToList();

            if (list.Count == 0)
            {
                list = _context.Customers.Where(c => c.Givenname.StartsWith(search) || c.Surname.StartsWith(search)).ToList();
            }

             if(list.Count == 0)
            {
                list = _context.Customers.Where(k => k.Givenname.StartsWith(nam)  && k.City.Contains(city)).ToList();
            }
           

            const int pagesize = 50;

            var totalNumber = list.Count();

            var customers = list.Skip(pagesize * (page - 1)).Take(pagesize);

            var modelCustomers = new CustomerInformationViewModel
            {
                Search = search,
                pageNumber = page,
                pageSize = pagesize,
                TotalNumberOfItems = totalNumber,

                ShowMore = page * pagesize < totalNumber,
                customerslist = customers.ToList()

            };

            return View("SearchCustomer", modelCustomers);

        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchByCustomerId( int id)
        {
            if(id == 0 )
            {
                TempData["success"] = "abc";
                return View(new Customers());
            }
        
            Customers cusId = _context.Customers.SingleOrDefault(m => m.CustomerId == id);

            return View(cusId);

        }
        [HttpGet]
        public IActionResult SearchByCustomerId()
        { 
            return View(new Customers());

        }

       
        //Create new customer:

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            CreateCustomerViewModel model = new CreateCustomerViewModel();

            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCustomer(CreateCustomerViewModel register )
        {
            
            if (ModelState.IsValid)
            {
                Customers newCustomer = new Customers()
                {
                    Gender = register.Gender,
                    Givenname = register.Givenname,
                    Surname = register.Surname,
                    Streetaddress = register.Streetaddress,
                   City = register.City,
                    Zipcode = register.Zipcode,
                    Country = register.Country,
                    CountryCode = register.CountryCode,
                    Birthday = register.Birthday,
                    NationalId = register.NationalId,
                    Telephonecountrycode = register.Telephonecountrycode,
                    Telephonenumber = register.Telephonenumber,
                    Emailaddress = register.Emailaddress
            };
                
                Accounts account = new Accounts()
                {
                    Frequency = "Monthly",
                    Created = DateTime.Now,
                    Balance = 0m
                };

                Dispositions disposition = new Dispositions()
                {
                    Type = "Owner",
                    Customer = newCustomer,
                    Account = account
                };

                register.Account = account;
                register.Disposition = disposition;

                _context.Add(newCustomer);
                _context.Add(register.Account);
                _context.Add(register.Disposition);

                _context.SaveChanges();

               
                return RedirectToAction("CreateCustomerSuccess");
            }
            else
            {
                return View(register);
            }

        }

        // CreateCustomerSuccess:
        [HttpGet]
        public IActionResult CreateCustomerSuccess()
        {
            return View();
        }



        [HttpGet]
        public IActionResult updateCustomer(int id)
        {
            var model = new CustomerInformationViewModel();
            model.customerInfo = _context.Customers.SingleOrDefault(k => k.CustomerId == id);
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult updateCustomer(CustomerInformationViewModel model, int id)
        {
          
            var newCus = _context.Customers.SingleOrDefault(k => k.CustomerId == id);

            if (model.customerInfo == null)
            {
                model.customerInfo = newCus;
            }
            else
            {
                newCus.Gender = model.customerInfo.Gender;
                newCus.Givenname = model.customerInfo.Givenname;
                newCus.Surname = model.customerInfo.Surname;
                newCus.Streetaddress = model.customerInfo.Streetaddress;
                newCus.City = model.customerInfo.City;
                newCus.Zipcode = model.customerInfo.Zipcode;
                newCus.Country = model.customerInfo.Country;
                newCus.CountryCode = model.customerInfo.CountryCode;
                newCus.Birthday = model.customerInfo.Birthday;
                newCus.NationalId = model.customerInfo.NationalId;
                newCus.Telephonecountrycode = model.customerInfo.Telephonecountrycode;
                newCus.Telephonenumber = model.customerInfo.Telephonenumber;
                newCus.Emailaddress = model.customerInfo.Emailaddress;

                _context.SaveChanges();
                return RedirectToAction("updateSuccess");

            }

            return View(model);

        }


        [HttpGet]
        public IActionResult updateSuccess()
        {
            return View( );
        }
 

    }
}


