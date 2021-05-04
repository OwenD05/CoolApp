using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace MyCoolApp.buttons
{
    class FirstEditedDate : ILabel
    {
        public Label GetLabel(MainWindow window)
        {
            return window.FirstCreated;
        }

        public string UpdateField(string path)
        {
            DateTime modified = System.IO.File.GetCreationTime(path);
            return modified.ToString("dd/MM/yy HH:mm:ss");
        }
    }
}
