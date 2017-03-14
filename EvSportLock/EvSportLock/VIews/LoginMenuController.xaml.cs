using EvSportLock.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EvSportLock
{
    public partial class LoginMenuController : MasterDetailPage
    {
        LoginMenuPage LoginMenuPage;
        private LogInPage loginpage;

        public LoginMenuController()
        {
            try
            {
                InitializeComponent();
                LoginMenuPage = new LoginMenuPage();
                loginpage = new LogInPage();
                Master = LoginMenuPage;
                Detail = loginpage;

            }
            catch (Exception ex)
            {

            }

        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                LoginMenuPage.CloseButton.Clicked += MenuClicked;
                LoginMenuPage.MenuListView.ItemTapped += MenuListView_ItemTapped;
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnDisappearing()
        {
            try
            {
                base.OnDisappearing();
                LoginMenuPage.CloseButton.Clicked -= MenuClicked;
                LoginMenuPage.MenuListView.ItemTapped -= MenuListView_ItemTapped;
            }
            catch (Exception ex)
            {

            }
        }

        private void MenuClicked(object sender, EventArgs e)
        {
            try
            {
                IsPresented = false;
            }
            catch (Exception ex)
            {

            }
        }

        void MenuListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                LoginMenuPageItem menuItem = e.Item as LoginMenuPageItem; ;
                IsPresented = false;
                LoginMenuPage.MenuListView.SelectedItem = null;

                if (menuItem.pageName == "admin")
                {
                    loginpage = ((Page)Activator.CreateInstance(menuItem.pageType)) as LogInPage;
                    //loginpage.MenuIcon.GestureRecognizers.Add(menuIconTapped);
                    Detail = loginpage;

                }
                if (menuItem.pageName == "supplier")
                {
                    loginpage = ((Page)Activator.CreateInstance(menuItem.pageType)) as LogInPage;
                    //loginpage.MenuIcon.GestureRecognizers.Add(menuIconTapped);
                    Detail = loginpage;

                }

                if (menuItem.pageName == "Ev Driver")
                {
                    loginpage = ((Page)Activator.CreateInstance(menuItem.pageType)) as LogInPage;
                    //loginpage.MenuIcon.GestureRecognizers.Add(menuIconTapped);
                    Detail = loginpage;

                }

            }
            catch (Exception ex)
            {

            }
        }

    }
}