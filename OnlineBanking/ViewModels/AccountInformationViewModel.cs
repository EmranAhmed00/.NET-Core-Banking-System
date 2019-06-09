using OnlineBanking.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.ViewModels
{
    public class AccountInformationViewModel
    {
        public List<Accounts> accountInformation { get; set; }
        public Accounts singleAccount { get; set; }
        public List<Transactions> transactionInformation { get; set; }

        public Transactions  singleTransaction { get; set; }


         public IPagedList<Accounts> pageAccount { get; set; }


        // Ajax Transactions:

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalNumberOfItems { get; set; }
        public bool CanShowMore { get; set; }

        public IList<Transactions> Itransactions{ get; set; }



    }

}


