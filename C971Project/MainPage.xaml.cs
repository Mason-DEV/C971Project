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
            this.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

        public async Task NavigateFromMenu(int ID)
        {
            switch (ID)
            {
                case 1:
                    PushPage(new HomePage());
                    return;
                case 2:
                    //PushPage(new TermsPage());
                    return;
                case 3:
                    //PushPage(new CoursePage());
                    return;
                case 4:
                    //PushPage(new AssesmentsPage());
                    return;
                case 5:
                    PushPage(new SettingsPage());
                    return;
            }

            var newPage = new NavigationPage(new HomePage());
            Detail = newPage;

            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(100);

            IsPresented = false;
        }

        public async void PushPage(ContentPage page)
        {
            //Before we push new page, make sure what we are pushing isnt current page
            //Console.WriteLine("Detail = "+Detail.Title.ToString());
            //Console.WriteLine("Page = "+Page.TitleProperty.ToString());
            var detail = Application.Current.MainPage.Title;
            Console.WriteLine("detail =" + detail);
            await Detail.Navigation.PushAsync(page);

            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(100);

            IsPresented = false;
        }
    }
}


