using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luval_dragdrop
{

    
    public class DragDropSim
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern string SendMessage(int hWnd, int msg, string wParam, IntPtr lParam);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern ushort GlobalFindAtom(string lpString);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetProp(int hWnd, string lpString);

        public  void DoDragDrop()
        {

        }

        public ushort GlobalFind(string text)
        {
            return GlobalFindAtom(text);
        }

        private IDropTarget GetTarget()
        {
            return null;
        }


    }
}
