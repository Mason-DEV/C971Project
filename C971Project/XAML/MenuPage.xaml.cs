using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C971Project.CS;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace C971Project.XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        public ObservableCollection<MenuItems> menuItems { get; set; }

        public MenuPage()
        {
            InitializeComponent();

            menuItems = new ObservableCollection<MenuItems>();
            menuItems.Add(new MenuItems { ID = 1, Name = "Home", Image = "" });
            menuItems.Add(new MenuItems { ID = 2, Name = "Terms", Image = "" });
            menuItems.Add(new MenuItems { ID = 3, Name = "Courses", Image = "" });
            menuItems.Add(new MenuItems { ID = 4, Name = "Assesments", Image = "" });
            menuItems.Add(new MenuItems { ID = 5, Name = "Settings", Image = "" });
            menuListView.ItemsSource = menuItems;
            //fix selected item for highlight
            menuListView.SelectedItem = menuItems[0];
            menuListView.ItemSelected += async(sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                int ID= (int)((MenuItems)e.SelectedItem).ID;
                await RootPage.NavigateFromMenu(ID);
            };
        }

        

    }

}