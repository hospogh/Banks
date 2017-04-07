using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(date1.Year - 50, date1.Month, date1.Day);

            Person person1 = new Person("Grigory", "Leps", date2, "1232112453212");
            Account account1 = new Account(person1, date1, "AMD");
            account1.DepositMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account1.DepositMoney(2000.0m, DateTime.Parse("04.04.2017"));
            account1.WithdrawMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account1.DepositMoney(500.0m, DateTime.Parse("5.04.2017"));
            account1.WithdrawMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account1 += 1500.0m;
            account1 -= 750;
            account1.PrintAccountStatement();

            Account account2 = new Account(person1, DateTime.Parse("06.04.2017"), "AMD");
            account2.DepositMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account2.DepositMoney(2000.0m, DateTime.Parse("04.04.2017"));
            account2.WithdrawMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account2.DepositMoney(500.0m, DateTime.Parse("5.04.2017"));
            account2 += 1500.0m;
            account2 -= 750;
            account2.PrintAccountStatement();

            Console.WriteLine(account1 > account2);



            Bank bank = new Bank("Ameria");
            bank.AddAccount(account1);
            bank.AddAccount(account2);
            bank.HireEmployee(new Engineer("Jintonik", "Jorj", DateTime.Parse("11.02.1970"), "1232112453212", 5000000.0m, DateTime.Parse("12.05.2001")));
            bank.HireEmployee(new Manager("Yurik", "Jadzya", DateTime.Parse("11.02.1950"), "125646542453212", 30300.0m, DateTime.Parse("3.11.1998"), "engineering"));
            bank.HireEmployee(new Secretary("Anna", "Simonyan", DateTime.Parse("11.12.1999"), "AP2132132132132", 330300.0m, DateTime.Parse("3.10.1988")));

            bank.PrintEmployees();
            Console.WriteLine(bank.GetTotalBalance());

        }
    }
}
