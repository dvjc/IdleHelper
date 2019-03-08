using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IdleHelper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImgMergeFarm_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MergeFarm());
        }
    }
}
