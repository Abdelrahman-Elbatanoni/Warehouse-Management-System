using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Company
{
    public class Secretary
    {
        [Key]
        public int Secretary_Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual WareHouse WareHouse { get; set; }
    }
}
