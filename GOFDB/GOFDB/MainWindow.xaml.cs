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
using GOFDB.Clases;
using SQLite;

namespace GOFDB
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Guideuser> guideuser;
        public MainWindow()
        {
            InitializeComponent();
            guideuser = new List<Guideuser>();
            ReadDatabase();
        }

        void ReadDatabase()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Guideuser>();
                guideuser = (conn.Table<Guideuser>().ToList()).OrderBy(c => c.Username).ToList();
            }
            if (guideuser != null)
            {
                dgGuideuser.ItemsSource = guideuser;
            }
        }

        private void BtnLeave(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnStart(object sender, RoutedEventArgs e)
        {
            GOFDB.Guide form = new GOFDB.Guide();
            form.ShowDialog();
        }

        private void BtnRemove(object sender, RoutedEventArgs e)
        {
            GOFDB.Delete form = new GOFDB.Delete();
            form.ShowDialog();
        }

        private void BtnSearch(object sender, RoutedEventArgs e)
        {
            GOFDB.Readata form = new GOFDB.Readata();
            form.ShowDialog();
        }
    }
}
