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

namespace BeerStore.Pages
{
    /// <summary>
    /// Interaction logic for Datagrid.xaml
    /// </summary>
    public partial class DatosCervezas : Page
    {
        public DatosCervezas()
        {
            InitializeComponent();

            List<Beer> test = new List<Beer>();
            test = Beer.GetAll();
            InfoCerveza.ItemsSource = Beer.GetAll();
        }
    }
}
