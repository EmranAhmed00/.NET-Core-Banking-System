using OnlineBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.ViewModels
{
    public class StatisticsViewModel
    {
        public int NumberOfCustomers { get; set; }
        public int NumberOfAccounts { get; set; }
        public decimal TotalBalance { get; set; }

        public Customers numCus { get; set; }
    }
}
