using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpletApi.Domains
{

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
    }
}
