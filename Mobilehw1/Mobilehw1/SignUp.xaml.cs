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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void Btn_save_OnClicked(object sender, EventArgs e)
        {
            if (ent_password.Text != ent_password2.Text || ent_mail.Text == null || ent_password.Text == null ||
                ent_password2.Text == null)
            {
               await DisplayAlert("Error",
                    "You entered an incomplete or incorrect information. Please check that informations!", "Cancel");
            }
            else
            {
                Application.Current.Properties["Mail"] = ent_mail.Text;
                Application.Current.Properties["Password"] = ent_password.Text;
                Application.Current.Properties["Password2"] = ent_password2.Text;
              await  Application.Current.SavePropertiesAsync();
              await DisplayAlert("Thanks", "Now you can Login with your email address and password", "Ok");
              await  Navigation.PushAsync(new HomePage());
                //Giriş sayfasına yönlendir.
                
            }

        }
    }
}

