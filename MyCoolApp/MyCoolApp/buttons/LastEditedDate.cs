using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyCoolApp.buttons
{
    class LastEditedDate : ILabel
    {
        public Label GetLabel(MainWindow window)
        {
            return window.LastEdited;
        }

        public string UpdateField(string path)
        {
            DateTime modified = System.IO.File.GetLastWriteTime(path);
            return modified.ToString("dd/MM/yy HH:mm:ss");
        }
    }
}
