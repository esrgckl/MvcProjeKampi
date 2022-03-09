 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }         //kategori açıklaması
       
        //Status zaten bool olduğu için ekstra bir kısıtlama yapmama gerek yok.
        public bool CategoryStatus { get; set; }          //Statusu 'Durum' olarak çevirebiliriz. ilişili tablolarda silme işlemi yapmayacağız. 
                                                          //onun yerine aktif ya da pasif işlemini tercih edeceğiz. Neden? 
                                                          //diyelim ki Yazılım kategorisini sildim. Ne olacak biliyor musun
                                                          //Kategorisi yazılım olan Heading'ler(Başlıklar) da silinecek.
                                                          //Başlıklar silinince doğal olarak içerikler de gidecek.

        public ICollection<Heading> Headings { get; set; }  //<> içine ilişki içine almak istediğin sınıfın ismini yazman gerekiyor.
                                                            //Bire-çok bir ilişki kurulacak. bunun bir kısmını hallettim. İşim bitti mi? Bitmedi.
                                                            //Şimdi bunu bir de Heading tarafında gerçekleştirmek gerekiyor.
                                                            //Heading tarafında 2 tane property daha tanımlıycam.
                                                            //!! Category tablosundaki ID'nin ismiyle aynı olmak üzere

    }
}
