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
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using BooksMaster.pages;

namespace BooksMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame frame;

        
        public MainWindow()
        {
            InitializeComponent();
            frame = mainFrame;
            frame.Content = new pages.Menu();
        }
        public static void ChangePage(Page page)
        {
            frame.Content = page;
        }
    }
}
