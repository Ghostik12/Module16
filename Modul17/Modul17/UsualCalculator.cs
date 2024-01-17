using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul17
{
    public class UsualCalculator : ICalculator
    {
        public void CalculateInterest(Account account)
        {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;
            else
                account.Interest -= account.Balance * 0.4;
        }
    }
}
