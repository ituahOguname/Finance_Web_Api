using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_FINANCE.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Ttile { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; } //Navigation Property
        public Stock? Stock { get; set; }
    }
}