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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Apartado.xaml
    /// </summary>
    public partial class Apartado : Window
    {
        public Apartado(String Usuario)
        {
            InitializeComponent();

            // Muestra el texto pasado en el TextBlock
            user.Text = Usuario;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
