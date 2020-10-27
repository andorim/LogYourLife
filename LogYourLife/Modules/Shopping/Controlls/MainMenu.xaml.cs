using LogYourLife.Modules.Shopping.Database.ObjectClasses;
using LogYourLife.Modules.Shopping.Pages;
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

namespace LogYourLife.Modules.Shopping.Controlls
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        ShoppingModule shoppingModule;
        MainWindow mainWindow;
        public MainMenu()
        {
            shoppingModule = App.shoppingModule;
            mainWindow = App.shoppingModule.mainWindow;
            InitializeComponent();
        }
        private void btnNewShopping_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnNewArticle_Click(object sender, RoutedEventArgs e)
        {
            shoppingModule.newArticle = new NewArticle();
            mainWindow.frMain.Navigate(shoppingModule.newArticle);
        }


        private void btnShowStores_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Store> ie = Store.getAll();
            shoppingModule.list = new ItemList(ie);
            mainWindow.frMain.Navigate(shoppingModule.list);
        }
        private void btnShowBrands_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Brand> ie = Brand.getAll();
            shoppingModule.list = new ItemList(ie);
            mainWindow.frMain.Navigate(shoppingModule.list);
        }

        private void btnShowMeasures_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<MeasureUnit> ie = MeasureUnit.getAll();
            shoppingModule.list = new ItemList(ie);
            mainWindow.frMain.Navigate(shoppingModule.list);
        }

        private void btnShowArticles_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Article> ie = Article.getAll();
            shoppingModule.list = new ItemList(ie);
            mainWindow.frMain.Navigate(shoppingModule.list);
        }
    }
}
