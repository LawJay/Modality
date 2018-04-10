using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace Main
{
    /// <summary>
    /// Interaction logic for Key.xaml
    /// </summary>
    public partial class Key : Window
    {
        
       

        public Key()
        {
            InitializeComponent();
        
        }

        private void Window_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.MessageBox.Show("Key Pressed : " + e.KeyChar);
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            String key = e.Key.ToString();
            System.Windows.MessageBox.Show("Key down : " + key);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
