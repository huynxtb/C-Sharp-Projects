using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_04.DTO.lab4
{
    class CategoryDTO
    {
        public int ID { get; set; }
        public string CateName { get; set; }
        public string Description { get; set; }
        public Byte[] Pricture { get; set; }
    }
}
