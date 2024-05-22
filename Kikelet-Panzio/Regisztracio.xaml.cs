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
using System.Windows.Shapes;

namespace KikeletPanzio
{

    public partial class Regisztracio : Window
    {
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void BtnMegse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A regisztráció sikertelen!");
        }
    }
}
a