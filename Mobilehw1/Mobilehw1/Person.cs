using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Mobilehw1
{
    class Person
    {
        public ObservableCollection<ModelForPerson> Kisiler { get; set; }

        public Person()
        {
            Kisiler = new ObservableCollection<ModelForPerson>
            {
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name= "Dr.Öğr. Üyesi Ahmet ARSLAN", mail = "aarslan2@anadolu.edu.tr" ,phoneNumber ="6553" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Prof.Dr. Yaşar HOŞÇAN", mail = "hoscan@anadolu.edu.tr" ,phoneNumber ="6558" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Assoc.Prof.Dr. Serkan GÜNAL", mail = "serkangunal@anadolu.edu.tr" ,phoneNumber ="6567" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Assoc.Prof.Dr. Cihan KALELİ", mail = "ckaleli@anadolu.edu.tr" ,phoneNumber ="6564" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Dr.Öğr. Üyesi Alper Kürşat UYSAL", mail = "akuysal@anadolu.edu.tr" ,phoneNumber ="6572" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Dr.Öğr. Üyesi Alper BİLGE", mail = "abilge@anadolu.edu.tr" ,phoneNumber ="6552" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Dr.Öğr. Üyesi Sevcan YILMAZ GÜNDÜZ", mail = "sevcany@anadolu.edu.tr" ,phoneNumber ="6554" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Res.Asst.Dr. Burcu YÜREKLİ YILMAZEL", mail = "byurekli@anadolu.edu.tr" ,phoneNumber ="6566" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Lect. Özgür ÖZŞEN", mail = "oozsen@anadolu.edu.tr" ,phoneNumber ="6557" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Lect. Emre KAÇMAZ", mail = "emrekacmaz@anadolu.edu.tr" ,phoneNumber ="6561" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Lect. Reha Oğuz ALTUĞ", mail = "roaltug@anadolu.edu.tr" ,phoneNumber ="6524" },
                new ModelForPerson{fotoUrl = "http://ceng.eskisehir.edu.tr/img/aarslan2.jpg", name = "Res.Asst. Alper YARGIÇ", mail = "ayargic@anadolu.edu.tr" ,phoneNumber ="6578" }
               }; 
        }
    }
}
