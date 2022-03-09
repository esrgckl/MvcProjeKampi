using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }

        [StringLength(1000)]
        public string AboutDetails1 { get; set; } //Burda alacağım bir tane tema var. o temada 2 farklı nokta var.
                                                  //2 farklı nokta olduğundan dolayı details kısmında 2 ayrı detay oluşturcam.
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; } //Resimleri dosya yolu olarak tutacağım. 
                                                //Çünkü resimleri sunucuma eklemek çok sağlıklı bir yöntem değil.
                                                //Çok tercih edilen bir yöntem değil.Resimler ayrı bir yere yüklenir.
                                                //O resimlerin dosya yolları veritabanından çekilir.
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
