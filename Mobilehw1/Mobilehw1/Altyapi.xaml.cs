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
    public partial class Altyapi : ContentPage
    {
        public Altyapi()
        {
            InitializeComponent();
          
        }

        
        private async void ItemsListView_OnItemTapped(object sender, EventArgs e)
        {

            var img_alt = (Image) sender;
           
            if (img_alt!=null)
            {
                string img_source = img_alt.Source.ToString();
                string img_url = img_source.Substring(5, img_source.Length - 5);
                ModelForAlt img_model = new ModelForAlt {aciklama = "sss", esyaAdi = "sss", fotoUrl = img_url};
                await Navigation.PushAsync(new ImageForAlt(img_model));

            }
        }


        
    }
}