using System.Collections.Generic;

namespace BulkyBookII.Models.ViewModels
{
    public class OrderDetailsVM
    {
        public OrderHeader OrderHeader { get; set; }

        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
