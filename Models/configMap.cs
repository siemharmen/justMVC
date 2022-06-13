using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReversiMVC.Models
{
    public class configMap
    { 

        public int[] chartInfo { get; set; }
        public int[] chartTurn { get; set; }

        public configMap(int[] chartInfo, int[] chartTurn)
        {
            this.chartInfo = chartInfo;
            this.chartTurn = chartTurn;
        }
    }
}
