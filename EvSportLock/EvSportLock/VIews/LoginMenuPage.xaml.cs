using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EvSportLock
{
    public partial class LoginMenuPage : ContentPage
    {
        public ListView MenuListView { get { return menuListView; } }
        //public Image CloseButton { get { return closeButton; } }
        public Button CloseButton { get { return closeButton; } }

        public LoginMenuPage()
        {
            InitializeComponent();
            Title = "EvSportLock";
            Icon = "icon.png";
            BindingContext = new VIewModels.LoginMenuVIewModel();
        }
    }
}
