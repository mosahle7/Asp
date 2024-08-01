using System;
using System.Collections.Generic;
using Humanizer;
namespace StuffyBankLibrary
{
    public class Transaction
    {
        public decimal Amount {get;}
        public string AmountForHumans {
            get
            {
                return ((int)Amount).ToWords();
            }
        }
        public DateTime Date {get;}
        public string Notes {get;}
        public Transaction(decimal amount,DateTime date,string note)
        {
            Amount=amount;
            Date=date;
            Notes=note;
        }
    }
}