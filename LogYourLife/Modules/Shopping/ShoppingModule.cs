using LogYourLife.Modules.Shopping.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogYourLife.Modules.Shopping
{
    public class ShoppingModule
    {
        public MainMenu mainMenu;
        public MainWindow mainWindow;

        public ShoppingModule()
        {
            
        }
        public void Init()
        {
            mainMenu = new MainMenu();
            mainWindow = new MainWindow();
            mainWindow.Show();
        }
        
    }
}
