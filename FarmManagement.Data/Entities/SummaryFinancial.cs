using System.ComponentModel.DataAnnotations.Schema;

namespace FarmManagement.Data
{
    public class SummaryFinancial
    {
        public string Name { get; set; }
        public decimal Sum { get; set; }

        [NotMapped]
        public int Month { get; set; }
    }
}
