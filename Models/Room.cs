using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        public int No { get; set; }
        public string RoomId { get; set; }
        public string RoomName { get; set; }
        public List<User> Users { get; set; }
    }
}