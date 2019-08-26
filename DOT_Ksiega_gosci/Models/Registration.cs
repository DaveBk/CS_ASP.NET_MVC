using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DOT_Ksiega_gosci.Models
{
    public class Registration
    {
        public int ID { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }
        //[Required]
        [StringLength(6, MinimumLength = 4)]
        public string Gender { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(250, MinimumLength = 6)]
        public string Contents { get; set; }  
    }
    public class RegistrationDBContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }
    }

}