using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipesWebAPI.Models
{
    public class Receipt
    {
        public string ReceiptId { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
