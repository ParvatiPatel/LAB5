using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB5.Models
{
    public class Song
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Duration { get; set; }
    }
}