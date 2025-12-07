using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Model
{
    public class StockHistory
    {
        [Key]                       // ❗ REQUIRED
        public int HistoryId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int ChangeAmount { get; set; }
        public string ChangeType { get; set; }  // Stock-In / Stock-Out
        public DateTime Date { get; set; } = DateTime.Now;

        public Product Product { get; set; }
    }
}
