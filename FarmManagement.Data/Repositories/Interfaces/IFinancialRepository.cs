using System.Collections.Generic;

namespace FarmManagement.Data.Interfaces
{
    public interface IFinancialRepository: IRepository<FinancialAsset>
    {
       decimal GetTotalForIncomeOrExpense(int IncomeOrExpense=0);
       IEnumerable<SummaryFinancial> GetTotalForFinancialType(int month, int financialTypeGroup=0);
    }
}
