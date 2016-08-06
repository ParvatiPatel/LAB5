using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB5.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }


    }
}
