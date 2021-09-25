using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AzureSqLDb.Models
{
    public class BookClass
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string publishers { get; set; }
        public double price { get; set; }
    }
}
