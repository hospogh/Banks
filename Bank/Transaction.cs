using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class Transaction
    {
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public Transaction(decimal money, DateTime date)
        {
            Money = money;
            Date = date;
        }
        public override string ToString()
        {
            return Date.ToString() + " " + Money;
        }
    }
}
