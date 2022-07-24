using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceControlServices.Models
{
    public class YearlyBalanceServiceModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<QuarterlyBalanceServiceModel> QuarterlyBalances { get; set; }
    }
}
