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

namespace LogYourLife.Modules.Shopping.Pages
{
    /// <summary>
    /// Interaktionslogik für List.xaml
    /// </summary>
    public partial class ItemList : Page
    {
        public ItemList()
        {
            InitializeComponent();
        }
        public ItemList(IEnumerable<Object> list)
        {
            InitializeComponent();
            foreach( object obj in list)
            {
                lbMain.Items.Add(obj.ToString());
            }
        }
    }
}
