using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBanking.Models;
using OnlineBanking.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineBanking.Controllers
{
    public class TransactionController : Controller
    {
        private BankAppDataContext _context;

        public TransactionController(BankAppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Deposit()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deposit(TransactionViewModel model , int id)
        {

         if (ModelState.IsValid)
            {

                var account = _context.Accounts.SingleOrDefault(k => k.AccountId == model.newTransaction.AccountId);
                
               
                var transaction = new Transactions
                {
                    AccountId = account.AccountId,
                    Amount = model.newTransaction.Amount,
                    Date = DateTime.Now,
                    Type = "Credit",
                    Operation = "Credit in cash",
                    Balance = account.Balance + model.newTransaction.Amount,
                    AccountNavigation = account
                };

                account.Balance += model.newTransaction.Amount;

                _context.Transactions.Add(transaction);
                _context.SaveChanges();

                return RedirectToAction("depositSuccess");

            }


            return View(model);

        }


        [HttpGet]
        public IActionResult Transfer()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Transfer(int fromAcc , int toAcc, decimal amount)
        {
            if (ModelState.IsValid)
            {

                var model = new TransactionViewModel();
                var account1 = _context.Accounts.SingleOrDefault(k => k.AccountId == fromAcc);
                var account2 = _context.Accounts.SingleOrDefault(k => k.AccountId == toAcc);

                if (amount <= account1.Balance)
                {

                    var transFrom = new Transactions()
                    {
                        AccountId = account1.AccountId,
                        Date = DateTime.Now,
                        Type = "Debit",
                        Operation = "Withdrawal in cash",
                        Amount = amount * -1,
                        Balance = account1.Balance - amount
                    };

                    account1.Balance -= amount;

                    var transTo = new Transactions()
                    {
                        AccountId = account2.AccountId,
                        Date = DateTime.Now,
                        Type = "Credit",
                        Operation = "Credit in cash",
                        Amount = amount,
                        Balance = account1.Balance + amount
                    };

                    account2.Balance += amount;
                    _context.Add(transFrom);
                    _context.Add(transTo);
                    _context.SaveChanges();
                    return RedirectToAction("TransferSuccess");

                }
            }

            TempData["success"] = "abc";
            return View();
        }

      [HttpGet]
        public IActionResult WithDrawal()
        {
         
           return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WithDrawal(TransactionViewModel model, int id  )
        { 
            if (ModelState.IsValid)
            {
                var newWithdraw = model.newTransaction;
                var account = _context.Accounts.SingleOrDefault(k => k.AccountId == model.newTransaction.AccountId);

                if (newWithdraw.Amount <= account.Balance && newWithdraw.Amount > 0)
                {
                    var transaction = new Transactions
                    {
                        AccountId = account.AccountId,
                        Amount = model.newTransaction.Amount,
                        Date = DateTime.Now,
                        Type = "Debit",
                        Operation = "Withdrawal in cash",
                        Balance = account.Balance - model.newTransaction.Amount,
                        AccountNavigation = account
                    };

                    account.Balance -= model.newTransaction.Amount;
                    _context.Transactions.Add(transaction);
                    _context.SaveChanges();
                  
                    return RedirectToAction("withdrawalSuccess");
                }
            }

            TempData["success"] = "abc";
           
             return View();
        }


        [HttpGet]
        public IActionResult depositSuccess()
        {
            return View();
        }

        [HttpGet]
        public IActionResult withdrawalSuccess()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TransferSuccess()
        {

            return View();
        }


    }
}


