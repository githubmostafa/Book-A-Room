using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Book_A_Room.Models
{
    public class AvailableRoom
    {
        [Key]
        public int AvailableRoomId { get; set; }
        [Display(Name ="Start Time")]
        [Column(TypeName = "datetime2")]
        public DateTime? BeginTime { get; set; }
        [Display(Name ="End Time")]
        [Column(TypeName = "datetime2")]
        public DateTime? EndTime { get; set; }
        [Display(Name ="Room")]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room room { get; set; }

    }
}