using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace Reading_.Dyn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, RoutedEventArgs e)
        {
                  
            // Configure open file dialog box
            OpenFileDialog dlg = new OpenFileDialog();
            
            dlg.FileName = "Document";                  // Default file name
            dlg.DefaultExt = ".dyn";                    // Default file extension
            dlg.Filter = "Text documents (.dyn)|*.dyn"; // Filter files by extension

            // Show open file dialog box
            dlg.ShowDialog();

            
            // Open document 
            string filename = dlg.FileName;
            txt_box.Text = filename;
                        
        }

        
    }
}
