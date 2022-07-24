using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceControlServices.Models
{
    public class QuarterlyBalanceServiceModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<MonthlyBalanceServiceModel> MonthlyBalances { get; set; }

        //Foreign Key
        [Required]
        public YearlyBalanceServiceModel YearlyBalance { get; set; }
    }
}
