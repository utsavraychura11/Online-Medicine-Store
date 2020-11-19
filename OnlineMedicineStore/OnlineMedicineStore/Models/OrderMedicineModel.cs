
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OnlineMedicineStore.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMedicineStore.Models
{
    public class OrderMedicineModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser Appuser { get; set; }

        public int OrderId { get; set; }
        public OrderModel Order { get; set; }

        public MedicineModel Medicines { get; set; }
        public int Quantity { get; set; }

        public int Price_total { get; set; }
    }
}
