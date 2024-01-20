using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNeighborhoodApp
{
    internal class MessageInfo
    {
        private string message, Sender, Receiver;
        private DateTime date;

        public void setMessage(string message) { this.message = message; }
        public string getMessage() { return message; }
        public void setSender(string sender) { this.Sender = sender; }
        public string getSender() { return Sender; }
        public void setReceiver(string receiver) { this.Receiver = receiver; }
        public string getReceiver() { return Receiver; }
        public void setDate(DateTime date) { this.date = date; }
        public DateTime getDate() { return date; }

    }
}
