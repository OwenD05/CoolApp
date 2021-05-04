using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyCoolApp.buttons
{
    interface ILabel
    {

        String UpdateField(String path);


        Label GetLabel(MainWindow window);

    }
}
