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
using System.Xml.Linq;




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
            
            //Main Windows Title
            form.Title = "Dynamo File Reader";

        }

        /// <summary>
        /// Buttom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            bool verify = archiveFile.Contains("<Workspace Version=");

            // Delete test file
            File.Delete(combine);

            
            //Conditional - Xml or Json?
            if (verify)
            {
                
                var combineXml = Path.Combine(dirName, fileName + ".xml");

                // Copy temp file
                File.Copy(fullroute, combineXml, true);

                // Create XML Document Object
                XDocument xmlDoc = XDocument.Load(combineXml);

                //Query attributes of Workspace XmlNode
                var queryWork = from x in xmlDoc.Descendants("Workspace") select x;

                IEnumerable<XAttribute> enumerable = queryWork.Attributes();

                List<XAttribute> list = enumerable.ToList();

                //Show version
                txt_box_Dynamo_Version.Text = list[0].Value;

                // Show Packages version
                var queryEle = from y in xmlDoc.Descendants("Elements") select y;

                IEnumerable<XNode> enumerable1 = queryEle.DescendantNodes();
                List<XNode> nodes = enumerable1.ToList();

                // Show Packages no info version
                // Create a list of parts.


                // Change visibility of elements
                listViewPackages.Visibility = Visibility.Collapsed;
                noAvailable.Visibility = Visibility.Visible;                

                // Delete File
                File.Delete(combineXml);

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
                listViewPackages.ItemsSource = packages;

                // Change visility of elements
                listViewPackages.Visibility = Visibility.Visible;
                noAvailable.Visibility = Visibility.Collapsed;

                // Delete File
                File.Delete(combineJson);

            }


            //Read dynamo version label
            string result = txt_box_Dynamo_Version.Text;


            //Revit Version compatibility previus operations
            char[] point = { '.' };
            string [] parts = result.Split(point);

            string chain = String.Concat(parts);

            string chainCut = chain.Remove(3);

            int versionNumber = Convert.ToInt32(chainCut);

            //Revit Version compatibility                  
            if (versionNumber >= 061 & versionNumber <=063) 
            {
                txt_box_Dynamo_Compatibility.Text = "2013-2014";
            }
            else if (versionNumber >= 064 & versionNumber <= 070)
            {
                txt_box_Dynamo_Compatibility.Text = "2014";
            } 
            else if (versionNumber == 071)
            {
                txt_box_Dynamo_Compatibility.Text = "2014-2015";
            }
            else if (versionNumber >= 072 & versionNumber <= 082)
            {
                txt_box_Dynamo_Compatibility.Text = "2014-2015-2016";
            }
            else if (versionNumber >= 083 & versionNumber <= 089)
            {
                txt_box_Dynamo_Compatibility.Text = "2015-2016";
            }
            else if (versionNumber >= 090 & versionNumber <= 121)
            {
                txt_box_Dynamo_Compatibility.Text = "2015-...-2019";
            }
            else if (versionNumber >= 122 & versionNumber <= 132)
            {
                txt_box_Dynamo_Compatibility.Text = "2016-...-2019";
            }
            else if (versionNumber >= 133 & versionNumber <= 200)
            {
                txt_box_Dynamo_Compatibility.Text = "2017-2018-2019";
            }

        }

        
    }
}
