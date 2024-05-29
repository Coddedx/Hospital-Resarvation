using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalResarvation.Web.Models
{
    public class Room : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }


        [Required]
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }


        //[Required]
        //public int StaffId { get; set; }
        //[ForeignKey("StaffId")]
        //public virtual Staff Staff { get; set; }


        [Required]
        public int FranchiseId { get; set; }
        [ForeignKey("FranchiseId")]
        public virtual Franchise Franchise { get; set; }


        [Required]
        public DateTime EnterDate { get; set; }

        [Required]
        public DateTime ExitDate { get; set; }



    }
}
