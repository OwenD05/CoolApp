using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyCoolApp.buttons
{
    class FileContent : ILabel
    {
        public Label GetLabel(MainWindow window)
        {
            return window.FileContent;
        }

        public string UpdateField(string path)
        {
            return "PlaceHolder";
        }
    }
}
