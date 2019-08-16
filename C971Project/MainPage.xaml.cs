using C971Project.XAML;
using C971Project.CS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace C971Project
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public ObservableCollection<MenuItems> menuItems { get; set; }
        public MainPage()
        {
            InitializeComponent();
            this.Master = new MenuPage();
            this.Detail = new NavigationPage(new HomePage());
            //this.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

        public async Task NavigateFromMenu(int ID)
        {
            switch (ID)
            {
                case 1:
                    //PushPage(new HomePage());
                    await ChangePage(new NavigationPage(new HomePage()));
                    //this.Detail = new NavigationPage(new HomePage());
                    break;
                case 2:
                    //PushPage(new TermsPage());
                    break;
                case 3:
                    //PushPage(new CoursePage());
                    break;
                case 4:
                    //PushPage(new AssesmentsPage());
                    break;
                case 5:
                    //this.Detail = new NavigationPage(new SettingsPage());
                    //PushPage(new SettingsPage());
                    await ChangePage(new NavigationPage(new SettingsPage()));
                    break;
            }
            IsPresented = false;
        }

        public Task ChangePage(NavigationPage page)
        {
            this.Detail = page;
            return Task.CompletedTask;
        }
    }
}


