using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicineStore.Data;
using OnlineMedicineStore.Models;

namespace OnlineMedicineStore.Data
{
    public class Item
    {
        public int OrderId { get; set; }

        public Medicine Medicines { get; set; }


        public int Quantity { get; set; }





    }
}
