using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OnlineMedicineStore.Models
{
    public class MedicineModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public int Price { get; set; }
        public bool IsPrescriptionRequired { get; set; }




    }
}
