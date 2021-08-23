using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HomeLang
    {
        public int homelangId { get; set; }
        public int? homeId { get; set; }
        public Home Home { get; set; }
        public string title { get; set; }
        public string slogan { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public string copyright { get; set; }
        public bool? varsayilan { get; set; }
        public bool? state { get; set; }        //not görünürlük durumu
        public bool? IsChecked { get; set; }    //notun silinip silinmediği
        public string lang { get; set; }
        public ICollection<Home_Lang> Home_Langs { get; set; }
    }
}
