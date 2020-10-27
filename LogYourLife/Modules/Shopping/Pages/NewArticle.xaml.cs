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

using LogYourLife.Modules.Shopping.Database.ObjectClasses;

namespace LogYourLife.Modules.Shopping.Pages
{
    /// <summary>
    /// Interaktionslogik für NewArticle.xaml
    /// </summary>
    public partial class NewArticle : Page
    {
        public NewArticle()
        {
            InitializeComponent();
            FillComboboxes();

        }
        void FillComboboxes()
        {

            FillStoreCb();
            FillBrandCb();
            FillMeasureUnitCb();
            
        }
        void FillStoreCb()
        {
            // Stores //
            cbStore.Items.Clear();
            IEnumerable<Store> stores = Store.getAll();
            foreach (Store st in stores)
            {
                ComboBoxItem cbI = new ComboBoxItem();
                cbI.Content = st.name;
                cbI.Tag = st.id;
                cbStore.Items.Add(cbI);
            }
        }
        void FillBrandCb()
        {
            // Brands //
            cbBrand.Items.Clear();
            IEnumerable<Brand> brands = Brand.getAll();
            foreach (Brand br in brands)
            {
                ComboBoxItem cbI = new ComboBoxItem();
                cbI.Content = br.name;
                cbI.Tag = br.id;
                cbBrand.Items.Add(cbI);
            }
        }
        void FillMeasureUnitCb()
        {
            // MeasureUnits //
            cbMeasureUnit.Items.Clear();
            IEnumerable<MeasureUnit> measureUnit = MeasureUnit.getAll();
            foreach (MeasureUnit mu in measureUnit)
            {
                ComboBoxItem cbI = new ComboBoxItem();
                cbI.Content = mu.name;
                cbI.Tag = mu.id;
                cbMeasureUnit.Items.Add(cbI);
            }
        }

        private void btnReloadStore_Click(object sender, RoutedEventArgs e)
        {
            FillStoreCb();
        }

        private void btnReloadBrand_Click(object sender, RoutedEventArgs e)
        {
            FillBrandCb();
        }

        private void btnReloadMeasure_Click(object sender, RoutedEventArgs e)
        {
            FillMeasureUnitCb();
        }

        private void btnAddStore_Click(object sender, RoutedEventArgs e)
        {
            App.shoppingModule.mainWindow.frMain.Navigate(new NewStore());
        }

        private void btnAddBrand_Click(object sender, RoutedEventArgs e)
        {
            App.shoppingModule.mainWindow.frMain.Navigate(new NewBrand());
        }

        private void btnAddMeasure_Click(object sender, RoutedEventArgs e)
        {
            App.shoppingModule.mainWindow.frMain.Navigate(new NewMeasure());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Article art = new Article();
                art.name = tbName.Text;
                art.brandId = int.Parse(((ComboBoxItem)cbBrand.SelectedItem).Tag.ToString());
                art.amount = double.Parse(tbAmount.Text);
                art.measureId = int.Parse(((ComboBoxItem)cbMeasureUnit.SelectedItem).Tag.ToString());

                art.Insert();
                art.id = Article.getLastId();

                Price pr = new Price();
                pr.articleId = art.id;
                pr.storeId = int.Parse(((ComboBoxItem)cbStore.SelectedItem).Tag.ToString());
                pr.value = double.Parse(tbPrice.Text);
                pr.date = DateTime.UtcNow;
                pr.Insert();

                art.currentPriceId = Price.getLastId();

                art.Update();

                StoreArticle stArt = new StoreArticle(pr.storeId, art.id);
                stArt.Insert();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
