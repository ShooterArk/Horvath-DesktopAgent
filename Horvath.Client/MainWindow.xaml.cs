﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace Horvath.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleSwitch_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch tg = (ToggleSwitch)sender;
            if ((bool)tg.IsChecked)
            {
                codeBox.IsEnabled = false;
                progressRing.IsActive = true;
            }
            else
            {
                codeBox.IsEnabled = true;
                progressRing.IsActive = false;
            }
        }
    }
}
