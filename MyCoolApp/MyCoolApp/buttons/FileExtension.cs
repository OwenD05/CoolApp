using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyCoolApp.buttons
{
    class FileExtension : ILabel
    {
        public Label GetLabel(MainWindow window)
        {
            return window.Extension;
        }

        public string UpdateField(string path)
        {
            return Path.GetExtension(path);
        }
    }
}
