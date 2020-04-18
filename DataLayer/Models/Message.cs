using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Message
    {
        public int ID { get; set; }
        public Person SenderUser { get; set; }
        public Person ReciverUser { get; set; }
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
        public byte SeenStatus { get; set; } = 0;
        public DateTime SeenDate { get; set; }
    }
}
