using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Mobilehw1
{
    class Model2
    {
        public ObservableCollection<ModelForAlt> Esyalar { get; set; }

        public Model2()
        {
            Esyalar = new ObservableCollection<ModelForAlt>
            {
                new  ModelForAlt { esyaAdi = "Derslik-B1", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B1.jpg", aciklama = "Kapasite: 36"},
                new  ModelForAlt { esyaAdi = "Derslik-B2", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B2.jpg", aciklama = "Kapasite: 15"},
                new  ModelForAlt { esyaAdi = "Derslik-B3", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B3.jpg", aciklama = "Kapasite: 18"},
                new  ModelForAlt { esyaAdi = "Derslik-B4", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B4.jpg", aciklama = "Kapasite: 24"},
                new  ModelForAlt { esyaAdi = "Derslik-B5", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B5.jpg", aciklama = "Kapasite: 15"},
                new  ModelForAlt { esyaAdi = "Derslik-B6", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B6.jpg", aciklama = "Kapasite: 24"},
                new  ModelForAlt { esyaAdi = "Derslik-B7", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Class_B7.jpg", aciklama = "Kapasite: 54"},
                new  ModelForAlt { esyaAdi = "Lab-01", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Lab_PC1.jpg", aciklama = "Kapasite: 61 Pc"},
                new  ModelForAlt { esyaAdi = "Lab-02", fotoUrl = "http://ceng.eskisehir.edu.tr/Documents/Lab_Mac1.jpg", aciklama = "Kapasite: 24 İMac"}

            };
        }

    }
}
