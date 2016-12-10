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
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace Study_Chapter_5
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // DataContext에 ViewModel 개체를 assign 한다.
            this.DataContext = mvm;
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void ButtonTarget1_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(CheckBoxLegacy.IsChecked);

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TextBoxTarget1.Text = ofd.FileName;
            }
        }

        private void ButtonTarget2_Click(object sender, RoutedEventArgs e)
        {
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxTarget2.Text = ofd.FileName;
            }
        }

        private void ButtonSource1_Click_1(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxSource1.Text = ofd.FileName;
            }
        }

        private void ButtonSource2_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxSource2.Text = ofd.FileName;
            }
        }

        private void ButtonDelete1_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxDelete1.Text = ofd.FileName;
            }
        }

        private void ButtonDelete2_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxDelete2.Text = ofd.FileName;
            }
        }

        private void ButtonDelete3_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxDelete3.Text = ofd.FileName;
            }
        }

        private void ButtonAutoCheck1_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // TextBoxAutoCheck1.Text = ofd.FileName;
                mvm.ListBoxItems.Add(ofd.FileName);
            }
        }

        private void ButtonAutoCheck2_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxAutoCheck2.Text = ofd.FileName;
            }
        }

        private void ButtonAutoCheck3_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxAutoCheck3.Text = ofd.FileName;
            }
        }

        public void filecopy()
        {
            string fileName = "";
            string sourcePath = "";
            string targetPath = TextBoxTarget2.Name;
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string targerFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, targerFile, true);

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    targerFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, targerFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }

        private void ButtonCopyStart1_Click(object sender, RoutedEventArgs e)
        {
                mvm.CheckBoxChecked = !mvm.CheckBoxChecked;
        }
    }
}
