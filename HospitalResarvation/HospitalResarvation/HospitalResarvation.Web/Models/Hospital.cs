﻿using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class Hospital : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(64)]
        public string Name { get; set; }

        [Required,StringLength(128)]
        public string Adress { get; set; }

        [Required,StringLength(64)]
        public string Email { get; set; }

        [Required,StringLength (13)]
        public string Phone { get; set; }

        public ICollection<Department?>? Departments { get; set; }
        // public string Code { get; set; }

    }
}