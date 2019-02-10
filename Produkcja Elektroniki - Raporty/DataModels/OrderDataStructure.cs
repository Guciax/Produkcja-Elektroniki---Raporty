using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkcja_Elektroniki___Raporty.DataModels
{
    public class OrderDataStructure
    {
        public OrderDataStructure(MST.MES.OrderStructureByOrderNo.DataByProcess d)
        {
            this.d = d;
        }

        MST.MES.OrderStructureByOrderNo.DataByProcess d
        {
            get;set;
        }

    }
}
