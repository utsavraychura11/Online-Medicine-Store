using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace OnlineMedicineStore.Data
{
    public class Medicine
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Medicine  Name")]
        [Display(Name = "medicine")]

        public string MedicineName { get; set; }

        [Required(ErrorMessage = "Please Enter Medicine's Description ")]
        [Display(Name = "Description")]


        public string Description { get; set; }
        
        [Required(ErrorMessage = "Please Enter Its category ")]
        [Display(Name = "category")]

        public string Category { get; set; }

        [Required(ErrorMessage = "Please Enter Price  ")]
        [Display(Name = "price")]

        public int Price { get; set; }

        [Required(ErrorMessage = "Please Enter whtether prescription will be required or not ")]
        [Display(Name = "prescription")]


        public bool IsPrescriptionRequired { get; set; }

    }
}
