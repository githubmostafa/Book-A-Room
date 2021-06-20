using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book_A_Room.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        [Display(Name ="Room Name")]
        public String RoomName { get; set; }


        [Required]
        [Range(1,30)]
        
        [Display(Name ="Attendees Capacity")]
        public int AttendeesCapacity { get; set; }
        
        [Required]
        
        public string Floor { get; set; }

    }
}