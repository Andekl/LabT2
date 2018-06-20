using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabT2.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Value { get; set; }
        public string Section { get; set; }
    }
}
