using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InputModels.FinanceControlInputModels
{
    public class QuarterlyBalanceInputModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<MonthlyBalanceInputModel> MonthlyBalances { get; set; }

        //Foreign Key
        [Required]
        public YearlyBalanceInputModel YearlyBalance { get; set; }
    }
}
