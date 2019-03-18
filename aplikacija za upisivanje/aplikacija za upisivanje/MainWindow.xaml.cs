using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace Vjez2_notepad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*)";
            if (fileDialog.ShowDialog() == true)
            {
                OpenText.Text = fileDialog.FileName;
                EditorTexBox.Text = "";
            }
            using (StreamReader stream = new StreamReader(OpenText.Text))
            {
                string s;
                while ((s = stream.ReadLine()) != null)
                {
                    EditorTexBox.Text += s;
                    EditorTexBox.Text += Environment.NewLine;
                }
            }
        }
    }
}
