using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeriChat
{
    public class Message
    {
        public string? Text { get; set; }
        public DateTime? Date { get; set; }
        public Message() { }
        public Message(string? text, DateTime? date)
        {
            Text = text;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Text} - {Date}";
        }
    }
}
