using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LearnRepos
{
    public class MySalesPerson
    {
        public int BusinessEntityID { get; set; }
        public int? TerritoryID { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public override string ToString()
        {
            return $"MySalesPerson: {TerritoryID}, {Bonus}, {SalesYTD},";
        }
    }
}
