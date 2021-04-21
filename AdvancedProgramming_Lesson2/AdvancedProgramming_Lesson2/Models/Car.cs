using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Producer { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
