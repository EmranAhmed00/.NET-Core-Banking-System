//using OnlineBanking.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Transactions;

//namespace OnlineBanking.ViewModels
//{
//    public class TransactionRepositoryViewModel
//    {
//        const int totalItems = 134;

//        public IList<Transactions> GetTransactions(int take, int skip)
//        {
//            // Simulera långsam databas!
//            //Thread.Sleep(3000);

//            var random = new Random();
//            var balance = 0;
           
//            var list = new List<Transactions>();

//            // Simulera databas - skapa 134 transaktioner 
//            for (int i = 0; i < totalItems; i++)
//            {
//                var amount = random.Next(1000000) - 500000;
//                balance = balance + amount;
                
//                var transaction = new Transactions
//                {
//                    TransactionId = i + 1,
//                    Amount = amount,
//                    Balance = balance,
                  
//                };
//                list.Add(transaction);
//            }

//            return list
//                .Skip(skip).Take(take)
//                .ToList();
//        }
//    }
//}
