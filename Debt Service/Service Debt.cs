using System.Collections.Generic;
using static Personal_Expense_Tracker.Components.Pages.Add_New_Debt;

public class DebtService
{
    private List<DebtModel> _debts = new List<DebtModel>();

    public List<DebtModel> GetAllDebts()
    {
        return _debts;
    }

    public void AddDebt(DebtModel debt)
    {
        _debts.Add(debt);
    }
}
