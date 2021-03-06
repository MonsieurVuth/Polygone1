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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Polygone1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Inference inference = new Inference(side.Text, angle.Text, para.Text, longueur.Text);
            inference.CheckRegles();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Inference inference = new Inference(side.Text, angle.Text, para.Text, longueur.Text);
            inference.EmptyBase();
        }
    }
}
