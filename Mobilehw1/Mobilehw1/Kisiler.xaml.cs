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
    public partial class Kisiler : ContentPage
    {
        public Kisiler()
        {
            InitializeComponent();
            
        }

        
        async void Button_OnClicked(object sender, EventArgs e)
        {
            var telno = ((Button) sender).BindingContext as Label;
            string tel = telno.Text;
            Label name = telno.BindingContext as Label;
            string telName = name.Text; 
            
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + telName + " ?"+" " +
                "GSM: "+tel,
                "Yes",
                "No"))
            {
                Device.OpenUri(new Uri("tel:" + tel));
            }
        }
    }
}