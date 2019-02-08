using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeExcelFiles
{
    class PosicEventArgs:EventArgs
    {
        public int posic;

        public PosicEventArgs(int pos):base()
        {
            posic = pos;
        }
    }
}
