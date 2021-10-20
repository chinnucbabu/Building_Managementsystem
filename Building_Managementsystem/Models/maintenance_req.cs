using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Building_Managementsystem.Models
{
    public class maintenance_req
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string buildingname { get; set; }

        [StringLength(50)]
        [Required]
        public string location { get; set; }

        [StringLength(50)]
        [Required]
        public string ownername{ get; set; }
        [Required]
        public double? phone { get; set; }

        [Required]
        public double? cost{ get; set; }




    }
}