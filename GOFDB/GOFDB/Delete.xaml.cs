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
    /// Lógica de interacción para Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void BtnDelete(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                string sentenciaSQL = "delete from guideuser where Username='" + txtUsername.Text + "'";
                conexion.Execute(sentenciaSQL);
            }
            Close();
        }

        private void BtnDcancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
