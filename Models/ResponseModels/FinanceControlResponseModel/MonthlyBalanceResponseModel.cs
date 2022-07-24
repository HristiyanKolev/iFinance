using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResponseModels.FinanceControlResponseModels
{
    public class MonthlyBalanceResponseModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<EntityResponseModel> Entities { get; set; }

        [Required]
        public ICollection<RecurringEntityResponseModel> RecurringEntities { get; set; }

        //Foreign Key
        [Required]
        public QuarterlyBalanceResponseModel QuarterlyBalance { get; set; }
    }
}
