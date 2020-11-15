using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_04.DTO.lab4
{
    class ProductDTO
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string Quarity { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int Order { get; set; }
        public int Reorder { get; set; }
        public int Discontinued { get; set; }
    }
}
