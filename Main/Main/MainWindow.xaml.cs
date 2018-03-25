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


namespace Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "/Modality/";
            listFilesInDirectory(path);



            //load modal files
           

            //insert modals into array list

            //load arraylist into System memory








        }

        static void listFilesInDirectory(string workingDirectory)
        {
            Modal test = new Modal(1, "test", "test", "test");

            string[] filePaths = Directory.GetFiles(workingDirectory);
            foreach(string filePath in filePaths)
            {
                Console.WriteLine(filePath);
                test.Load(filePath);
            }
        }



       

        private void JoyClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Joy Clicked");
            Joy j = new Joy();
            j.Show();
            
            
        }
        private void MicClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mic Clicked");
            Speech s = new Speech();
            s.Show();

        }
        private void KeyClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Key Clicked");
            Key k = new Key();
            k.Show();
           
        }

        private void keyBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            keyBtn.Source = new BitmapImage(new Uri("KeyboardBtn_hover.jpg", UriKind.RelativeOrAbsolute));

        }

        private void keyBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            keyBtn.Source = new BitmapImage(new Uri("KeyboardBtn.jpg", UriKind.RelativeOrAbsolute));
        }

        private void speechBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            speechBtn.Source = new BitmapImage(new Uri("MicBtn_hover.jpg", UriKind.RelativeOrAbsolute));
        }

        private void speechBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            speechBtn.Source = new BitmapImage(new Uri("MicBtn.jpg", UriKind.RelativeOrAbsolute));
        }

        private void joyBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            joyBtn.Source = new BitmapImage(new Uri("JoyStickBtn_hover.jpg", UriKind.RelativeOrAbsolute));
        }

        private void joyBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            joyBtn.Source = new BitmapImage(new Uri("JoyStickBtn.jpg", UriKind.RelativeOrAbsolute));
        }

        private void minimise(object sender, MouseEventArgs e)
        {
            


        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
