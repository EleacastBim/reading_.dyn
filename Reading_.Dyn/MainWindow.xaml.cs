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
using Newtonsoft.Json;
using System.IO;
using Path = System.IO.Path;
using System.Data;


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

            // Create and Configure open file dialog box
            OpenFileDialog dlg = new OpenFileDialog
            {
                FileName = "Document",                 // Default initial folder
                DefaultExt = ".dyn",                   // Default file extension
                Filter = "Dynamo Files (.dyn)|*.dyn"   // Filter files by extension
            };

            // Show open file dialog box
            dlg.ShowDialog();


            // Open document 
            var fullroute = dlg.FileName;
            var dirName   = Path.GetDirectoryName(fullroute);
            var fileName  = Path.GetFileNameWithoutExtension(fullroute);
            var combine   = Path.Combine(dirName,fileName + ".json");
            txt_box.Text  = fullroute;

            // Copy temp file
            File.Copy(fullroute, combine, true);

            // Reading JSON
            string fileJSON = File.ReadAllText(combine);

            // Extracting Data
            RootObject rs = JsonConvert.DeserializeObject<RootObject>(fileJSON);

            //var versionDynamo = rs.Name;


           
            var versionDynamo = rs.View.Dynamo.Version;
            // Delete temp File
            //File.Delete(combine);

            txt_box_ext.Text = combine;
            txt_box_fileName.Text = fileName;
            txt_box_dirName.Text = dirName;
            pantalla.Text = fileJSON;

            // Show Dynamo Version
            txt_box_nameppp.Text = versionDynamo;
                                                               
        }

        
    }
}
