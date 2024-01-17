using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul17
{
    public class SalaryCalculator : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
