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
    /// Interaktionslogik für NewStore.xaml
    /// </summary>
    public partial class NewStore : Page
    {
        public NewStore()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Store store = new Store();
            store.name = tbName.Text;
            store.Insert();
        }
    }
}
