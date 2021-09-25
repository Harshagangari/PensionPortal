using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppInAzureWithDatabase.Models
{
    public class MemeDialouges
    {
        [Key]
        public int id { get; set; }
        public string character { get; set; }
        public string dialouge { get; set; }
    }
}
