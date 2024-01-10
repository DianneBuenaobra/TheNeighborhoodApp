using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNeighborhoodApp
{
    internal class Concern
    {
        public string message, status, concern;
        public DateTime date;
        public string Imagepath;
        public int concernId;

        public Concern() 
        { 
            concernId = 0;
            date = DateTime.Now;
            concern = string.Empty;
            status = string.Empty;
            Imagepath = string.Empty;
            message = string.Empty;
        }  
        
        public Concern(int concernid, string message, string status, string concern, string imagepath, DateTime date)
        {
            this.concernId = concernid;
            this.message = message;
            this.status = status;
            this.concern = concern;
            this.date = date;
            this.Imagepath = imagepath;
        }

        public void copy(Concern concern)
        {
            concernId = concern.concernId;
            date = concern.date;
            Imagepath = concern.Imagepath;
            message = concern.message;
            status = concern.status;
            this.concern = concern.concern;
        }
    }
}
