using NEEQMM.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM.Model
{
    /// <summary>
    /// 资产单元
    /// </summary>
    public class Portfolio : Dictionary<string, Asset>
    {
        public int PortfolioID { get; private set; }
        public string PortfolioName { get; private set; }
        public double PortfolioCapital { get; set; }

        public Portfolio(int id, string name, double capital = 0):base()
        {
            PortfolioID = id;
            PortfolioName = name;
            PortfolioCapital = capital;
        }
    }
}
