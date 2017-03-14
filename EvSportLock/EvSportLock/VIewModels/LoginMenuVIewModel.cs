using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EvSportLock.VIewModels
{
    public class LoginMenuPageItem
    {
        public string pageIcon { get; set; }
        public string pageName { get; set; }
        public Type pageType { get; set; }
    }

    public class LoginMenuVIewModel : BindableObject
    {
        List<LoginMenuPageItem> loginmenuPages;
        public List<LoginMenuPageItem> LoginMenuPagesList
        {
            get { return loginmenuPages; }
            set
            {
                loginmenuPages = value;
                OnPropertyChanged("LoginMenuPagesList");
            }
        }

        public LoginMenuVIewModel()
        {
            LoginMenuPagesList = new List<LoginMenuPageItem> {
                new LoginMenuPageItem { pageName="admin", pageIcon="icon.png", pageType=typeof(LogInPage)},
                new LoginMenuPageItem { pageName="supplier", pageIcon="icon.png",  pageType=typeof(LogInPage)},
                new LoginMenuPageItem { pageName="EV Driver", pageIcon="icon.png", pageType=typeof(LogInPage)},
            };
        }
    }
}