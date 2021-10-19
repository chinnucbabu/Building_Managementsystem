namespace Building_Managementsystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    

    public partial class user_reg
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        [Required]
        public string username { get; set; }

        
        [StringLength(50)]
        [Required]
        [Display(Name ="Password")]
        [Column("password ")]
        public string password_ { get; set; }
        
        [StringLength(50)]
        [Required]
        public string address { get; set; }
        [Required]
        public double? phone { get; set; }
    }
}
