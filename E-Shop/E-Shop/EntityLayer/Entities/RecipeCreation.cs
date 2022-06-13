using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class RecipeCreation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bos gecilemes")]
        [Display(Name = "TC Kimlik Numarası")]
        
        public int CustomerTC { get; set; }


        [Required(ErrorMessage = "Bos gecilemes")]
        [Display(Name = "Reçeteli Ürün Ekleme")]
        [StringLength(150, ErrorMessage = "Max 150 karakter olmalidir.")]
        public string AdPrescriptionProduct { get; set; }


        
        [Required(ErrorMessage = "Bos gecilemes")]
        [Display(Name = "Reçete kodu:")]
        public Guid PrescriptionCode { get; set; }

       

        public virtual List<PrescriptionMedicine> PrescriptionMedicines { get; set; }
    }
}