using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Path = System.IO.Path;
using System.Data;
using ListViewItem = System.Windows.Controls.ListViewItem;
using System.Xml.Linq;

namespace Reading_.Dyn
{
    public class Backend
    {
        public static void openDialog()
        {
            // Create and Configure open file dialog box
            OpenFileDialog dlg = new OpenFileDialog
            {
                FileName = "Document",                 // Default initial folder
                DefaultExt = ".dyn",                   // Default file extension
                Filter = "Dynamo Files (.dyn)|*.dyn"   // Filter files by extension
            };

            // Show open file dialog box
            dlg.ShowDialog();

        }

    }
}
