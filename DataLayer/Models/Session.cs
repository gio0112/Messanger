using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Session
    {
        public int ID { get; set; }
        public Person UserID { get; set; }
        public DateTime SessionDate { get; set; }
        public byte Status { get; set; } = 1;
    }
}
