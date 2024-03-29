﻿using System;
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
    /// Lógica de interacción para Guide.xaml
    /// </summary>
    public partial class Guide : Window
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void BtnSubmit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to send your guide? \"NameGuide\"?", "Guide Of Somenthing", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Guide sent successfully!!", "Guide OfS");
                    Guideuser guideuser = new Guideuser()
                    {
                        Game = txtGame.Text,
                        Username = txtUsername.Text,
                        Guide = txtGuide.Text
                    };
                    using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
                    {
                        conexion.CreateTable<Guideuser>();
                        conexion.Insert(guideuser);
                    }
                    Close();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Well, you can edit more later.", "Guide OfS");
                    break;
            }
        }

        private void BtnGoback(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to close the window ?", "Guide Of Somenthing", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Oh come on!! :(", "Guide OfS");
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Yes!, Continue please.", "Guide OfS");
                    break;
            }
        }
    }
}
