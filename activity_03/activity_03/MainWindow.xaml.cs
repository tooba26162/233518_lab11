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

namespace activity_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        { 
            if (comboBox.SelectedItem != null) 
            { 
                ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem; 
                if (selectedItem != null) 
                { 
                    textBox.Text = selectedItem.Content.ToString(); 
                } 
            } 
        }
        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        { 
            if (comboBox1.SelectedItem != null) 
            { 
                ComboBoxItem selectedItem = comboBox1.SelectedItem as ComboBoxItem; 
                if (selectedItem != null) 
                { 
                    textBox1.Text = selectedItem.Content.ToString(); 
                } 
            } 
        }

    }
}

    

