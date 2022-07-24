using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResponseModels.FinanceControlResponseModels
{
    public class QuarterlyBalanceResponseModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<MonthlyBalanceResponseModel> MonthlyBalances { get; set; }

        //Foreign Key
        [Required]
        public YearlyBalanceResponseModel YearlyBalance { get; set; }
    }
}
