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
using ListViewItem = System.Windows.Controls.ListViewItem;

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
            var combine   = Path.Combine(dirName,fileName + ".txt");
            
            // Copy temp file
            File.Copy(fullroute, combine, true);

            // ReadFile
            string archiveFile = File.ReadAllText(combine);

            //Verify Data
            bool b = archiveFile.Contains("<Workspace Version");

            // Delete test file
            File.Delete(combine);

            if (b)
            {
                var combineXml = Path.Combine(dirName, fileName + ".xml");

                // Convert XML to json


            }
            else
            {
                
                var combineJson = Path.Combine(dirName, fileName + ".json");

                // Extracting Data
                RootObject rs = JsonConvert.DeserializeObject<RootObject>(archiveFile);

                // Show Dynamo Version
                var versionDynamo = rs.View.Dynamo.Version;
                txt_box_Dynamo_Version.Text = versionDynamo;

                // Show Packages version
                var packages = rs.NodeLibraryDependencies;


                // Charge Data at listview
                listviewpackages.ItemsSource = packages;

                // Delete File
                File.Delete(combineJson);

            }

        }

        
    }
}
