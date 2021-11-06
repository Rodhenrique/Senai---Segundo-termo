using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xamarin
{
    class Util
    {
        public static bool CampoVazio (Form cadastro){
        
            foreach(Control c in cadastro.Controls)
            {
                TextBox tbox = c as TextBox;

                if(tbox != null && tbox.Text.Trim().Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
