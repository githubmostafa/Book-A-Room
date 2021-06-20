using System;
using System.Collections.Generic;
using Book_A_Room.Models;

namespace Book_A_Room.ViewModels
{
    public class NewRoom
    {
      
        public IEnumerable<Room> rooms_ { get; set; }
        public AvailableRoom availableRoom { get; set; }

    }
}