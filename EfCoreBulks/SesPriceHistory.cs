using System;

namespace EfCoreBulks
{
    public class SesPriceHistory
    {
        public int Id { get; set; }
        public string RivileCode { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal PercentDiscount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
