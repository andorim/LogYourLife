using LogYourLife.Modules.Shopping.Database.ObjectClasses;
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

namespace LogYourLife.Modules.Shopping.Pages
{
    /// <summary>
    /// Interaktionslogik für NewBrand.xaml
    /// </summary>
    public partial class NewBrand : Page
    {
        public NewBrand()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Brand brand = new Brand();
            brand.name = tbName.Text;
            brand.Insert();
        }
    }
}
