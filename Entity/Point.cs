using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entity
{
    public class Point
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public float XCoord { get; set; }
        [Range(1, int.MaxValue)]
        public float YCoord { get; set; }
        [Range(1, int.MaxValue)]

        public float Radius { get; set; }
        public string? Color { get; set; }
        [NotMapped]
        public List<string>? Comments { get; set; }
    }
}