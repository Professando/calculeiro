using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace calculeiro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private async void Button_Conv_Base_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ConvBase());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
    }

