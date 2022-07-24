using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResponseModels.FinanceControlResponseModels
{
    public class YearlyBalanceResponseModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<QuarterlyBalanceResponseModel> QuarterlyBalances { get; set; }
    }
}
