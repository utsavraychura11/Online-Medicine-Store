using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore.Models
{
    public class MedicineModel
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
