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
    /// Interaktionslogik für NewMeasure.xaml
    /// </summary>
    public partial class NewMeasure : Page
    {
        public NewMeasure()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MeasureUnit measure = new MeasureUnit();
            measure.name = tbName.Text;
            measure.Insert();
        }
    }
}
