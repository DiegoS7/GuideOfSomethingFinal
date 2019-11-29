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
using GOFDB.Clases;
using SQLite;
namespace GOFDB
{
    /// <summary>
    /// Lógica de interacción para Readata.xaml
    /// </summary>
    public partial class Readata : Window
    {
        public Readata()
        {
            InitializeComponent();
        }

        private void BtnGoback(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSearch(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
