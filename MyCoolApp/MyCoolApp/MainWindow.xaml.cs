using MyCoolApp.buttons;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace MyCoolApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static ILabel[] labels = { new LastEditedDate(), new FileName(), new FileExtension(), new FirstEditedDate(), new FileContent() };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog(); 
            Nullable<bool> result = dlg.ShowDialog();
            if (result == false)
            {
                return;
            }

            string filename = dlg.FileName; 
            using (Icon ico = System.Drawing.Icon.ExtractAssociatedIcon(filename))
            {
                Picture.Source = Imaging.CreateBitmapSourceFromHIcon(ico.
                Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            } 
            foreach(ILabel label in labels)
            {
                label.GetLabel(this).Content = label.UpdateField(filename);
            }
        }
    }
}
