using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book_A_Room.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        [Display(Name ="Item Name")]
        [Required]
        public String ItemName { get; set; }

    }
}