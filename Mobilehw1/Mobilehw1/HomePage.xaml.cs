using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobilehw1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void btn_Login(object sender, System.EventArgs e)
        {
            if (ent_user.Text == "" || ent_pass.Text == "")
            {
                await DisplayAlert("Login Process", "Please Enter Your Information For Login", "OK");

            }
            else
            {
                if (ent_user.Text != Application.Current.Properties["Mail"].ToString() || ent_pass.Text != Application.Current.Properties["Password"].ToString())
                {
                    await DisplayAlert("Error", "Mail and Password dismatch!", "Cancel");
                }
                else
                {
                    await DisplayAlert("Ok!", "Welcome to ETU CENG App", "Go!");
                    await Navigation.PushAsync(new MainPage());

                }
            }
        }

        private async void btn_NavigateNew(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }
    }
}