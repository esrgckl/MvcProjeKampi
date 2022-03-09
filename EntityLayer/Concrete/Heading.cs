using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }

        public DateTime HeadingDate { get; set; }


        public int CategoryID { get; set; }  // Yani ne olacak? Heading tablomun içinde CategoryID isminde bir sütun olacak.
                                             //Peki bu CategoryID isimli sütunun ben ilişki içerisinde olup olmadığını nasıl belirliycem? Şöyle; tekrar prop
        public virtual Category Category { get; set; }  //virtual dediğime göre bir sınıftan değer alcam.
                                                        //Category sınıfından Category isminde bir property oluşturacaksın.


        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }



        public ICollection<Content> Contents { get; set; }
    }
}
