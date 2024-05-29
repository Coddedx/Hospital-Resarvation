using System.ComponentModel.DataAnnotations;

namespace HospitalResarvation.Web.Models
{
    public class RoomType : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
