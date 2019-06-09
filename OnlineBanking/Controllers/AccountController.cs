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
    public class AccountController : Controller
    {
        private BankAppDataContext _context;

        public AccountController(BankAppDataContext context)
        {
            _context = context;
        }

      
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchAccount(int search)
        {
           
            var accountList = new List<Accounts>();
            List<Accounts> model = _context.Accounts.Where(n => n.AccountId == search).ToList();
            
            return View(model);
      
        }

        [HttpGet]
        public IActionResult SearchAccount()
        {

            return View(new List<Accounts>());
        }


        [HttpGet]
        public IActionResult AccountInformation(int id)
        {
            var model = new AccountInformationViewModel();

            model.accountInformation = _context.Accounts.Where(n => n.AccountId == id).ToList();

            return View(model);
        }


        [HttpGet]
        public IActionResult accountTransaction(int accountId, int page  )
        {
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";

            const int pagesize = 20;

            var query = _context.Transactions.Where(k => k.AccountId == accountId).OrderByDescending(p => p.TransactionId);

            var totalNumber = query.Count(); 

            var transactions = query.Skip(pagesize* (page -1) ).Take(pagesize).ToList();

            var modelTransaction = new AccountInformationViewModel
            {
                PageNumber = page,
                PageSize = pagesize,
                TotalNumberOfItems = totalNumber,

                CanShowMore = page * pagesize < totalNumber,
                Itransactions = transactions

            };

            if (isAjax)
            {
                return PartialView("_TransactionRows", modelTransaction);
            }

            else
            {
                return View(modelTransaction);
            };

                
        }
    }
}

