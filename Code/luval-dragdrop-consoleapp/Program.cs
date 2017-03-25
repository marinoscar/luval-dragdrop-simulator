using luval_dragdrop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval_dragdrop_consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new DragDropSim();
            var res = obj.GlobalFind("OleDropTargetInterface");
        }
    }
}
