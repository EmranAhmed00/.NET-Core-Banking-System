using OnlineBanking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.ViewModels
{
    public class TransactionViewModel
    {
        
        public List<Accounts> accountTransaction { get; set; }
        
        public List<Transactions> moneyTransaction { get; set; }
        [Required]
        public Transactions  newTransaction { get; set; }

        //[Required]
        //public Accounts  accounts { get; set; }

        //public string tempData { get; set; }
    }
}




