using ShopTimeline.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopTimeline.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private CreditCardViewModel viewModel;

        public Login()
        {
            InitializeComponent();
            BindingContext = viewModel = new CreditCardViewModel();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)Application.Current.MainPage).PushAsync(new CreditCardView());
        }
    }
}