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
            // Stores //
            IEnumerable<Store> stores = Store.getAll();
            foreach (Store st in stores)
            {
                ComboBoxItem cbI = new ComboBoxItem();
                cbI.Content = st.name;
                cbI.Tag = st.id;
                cbStore.Items.Add(cbI);
            }

            // Brands //
            IEnumerable<Brand> brands = Brand.getAll();
            foreach(Brand br in brands)
            {
                ComboBoxItem cbI = new ComboBoxItem();
                cbI.Content = br.name;
                cbI.Tag = br.id;
                cbBrand.Items.Add(cbI);
            }

            // MeasureUnits //
            IEnumerable<MeasureUnit> measureUnit = MeasureUnit.getAll();
            foreach(MeasureUnit mu in measureUnit)
            {
                ComboBoxItem cbI = new ComboBoxItem();
                cbI.Content = mu.name;
                cbI.Tag = mu.id;
                cbMeasureUnit.Items.Add(cbI);
            }
        }
    }
}
