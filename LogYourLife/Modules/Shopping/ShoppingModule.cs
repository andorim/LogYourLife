using LogYourLife.Modules.Shopping.Controlls;
using LogYourLife.Modules.Shopping.Database.FunctionClasses;
using LogYourLife.Modules.Shopping.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogYourLife.Modules.Shopping
{
    public class ShoppingModule
    {
        public MainMenu mainMenu;
        public MainWindow mainWindow;

        public ItemList list;
        public NewStore newStore;
        public NewArticle newArticle;
        public NewBrand newBrand;
        public NewMeasure newMeasure;

        public ShoppingModule()
        {
            
        }
        public void Init()
        {
            DatabaseTools.Init();
            DatabaseTools.CreateTables();
            mainWindow = new MainWindow();
            mainMenu = new MainMenu();
            mainWindow.ShowMenu();
            mainWindow.Show();
        }

        void CreatePages()
        {
            this.list = new ItemList();
            this.newStore = new NewStore();
            this.newArticle = new NewArticle();
            this.newBrand = new NewBrand();
        }
        
    }
}
