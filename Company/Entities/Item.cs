using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Item
    {
        public Item()
        {
            WarehouseItems = new HashSet<WarehouseItem>();
        }
        [Key]
        public int ID {  get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string MeasurementUnit { get; set; }

        public ICollection<WarehouseItem> WarehouseItems { get; set; }
    }
}
