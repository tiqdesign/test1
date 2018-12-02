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
	public partial class ImageForAlt : ContentPage
	{
		public ImageForAlt (ModelForAlt model)
		{
			InitializeComponent ();
		    img_Model.Source = model.fotoUrl;

		}
	}
}