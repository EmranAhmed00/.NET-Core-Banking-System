using OnlineBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.ViewModels
{
    public class CustomerInformationViewModel
    {
        public Customers customerInfo { get; set; }

        public string Search { get; set; }

        public string cusName { get; set; }
        public string cusCity  { get; set; }
        public List<Accounts> accountInfo { get; set; }
        public decimal totalBalance { get; set; }

        //Paging Ajax
        public int pageNumber { get; set; }

        public int pageSize { get; set; }

        public int TotalNumberOfItems { get; set; }
        public bool ShowMore { get; set; }

        

        public List<Customers> customerslist { get; set; }

       
    }
}



