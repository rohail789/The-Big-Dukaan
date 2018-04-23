using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBigDukan.Models
{
    public class ProductModel
    {

        public int Product_ID { get; set; }

        public string Product_Name { get; set; }

        public string Product_Maker { get; set; }

        public int Cat_ID { get; set; }

        public int Vendor_ID { get; set; }

        public int Product_Quantity { get; set; }

        public int Product_Prize { get; set; }

        public string Product_Type { get; set; }

        public string Product_Details { get; set; }
        public string image { get; set; }
        public HttpPostedFileBase Image_new2 { get; set; }


    }
}