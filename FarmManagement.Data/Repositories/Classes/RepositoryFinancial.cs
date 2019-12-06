using System;
using System.Collections.Generic;
using FarmManagement.Data;
using FarmManagement.Data.Interfaces;
using FarmManagement.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Data.Repository
{
    public class RepositoryFinancial : RepositoryBase<FinancialAsset>, IFinancialRepository
    {
        public RepositoryFinancial(DbContext dbContext) : base(dbContext)
        {

        }
        public decimal GetTotalForIncomeOrExpense(int IncomeOrExpense)
        {
            var sql = "";
            if (IncomeOrExpense == 0)
            {
                sql = $@"select sum(""Total"")
                        from ""FinancialAssets""
                        where ""FinancialAssetTypeId""<5;";
            }
            else if (IncomeOrExpense == 1)
            {
                sql = $@"select sum(""Total"")
                        from ""FinancialAssets""
                        where ""FinancialAssetTypeId"">=5;";
            }
            // try
            // {
            //     var result = _dbContext.Database.ExecuteSqlCommand(sql);
            //     return result;
            // }
            // catch (Exception)
            // {
            //     return 0;
            // }
            return 0;
        }
        public IEnumerable<SummaryFinancial> GetTotalForFinancialType(int month, int financialTypeGroup = 0)
        {
            throw new System.NotImplementedException();
        }
    }
}
