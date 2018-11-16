using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpletApi.Models
{
    public class ProductCreateDto
    {
        public string Title { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
    }
}
