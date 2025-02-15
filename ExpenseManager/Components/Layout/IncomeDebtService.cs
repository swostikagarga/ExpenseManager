using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Components.Layout;


public class IncomeDebtService
{
    // The total income value
    public decimal TotalIncome { get; private set; } = 0m;

    // Method to decrease income (this happens when clearing debt)
    public void DecreaseIncome(decimal amount)
    {
        TotalIncome -= amount;
    }

    // Method to add income (when income transaction is added)
    public void IncreaseIncome(decimal amount)
    {
        TotalIncome += amount;
    }
}
