using Flex.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopTimeline.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardTemplate : ContentView
    {
        public CardTemplate()
        {
            InitializeComponent();
        }

        private void FlexButton_Clicked(object sender, EventArgs e)
        {

            selarrow.IsVisible = true;
            selarrow.Play();
            var bank = flexbtn.AutomationId;
          

        }


    }
}