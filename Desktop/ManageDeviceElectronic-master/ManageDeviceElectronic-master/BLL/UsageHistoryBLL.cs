using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class UsageHistoryBLL
    {
        UsageHistoryDAL usageDAL = new UsageHistoryDAL();
        public List<UsageHistory> SelectAllUsageHistory()
        {
            return usageDAL.SelectAllUsageHistory();
        }
        public bool UpdateUsageHistory(UsageHistory usage)
        {
            return usageDAL.UpdateUsageHistory(usage);
        }
    }
}
