using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InputModels.FinanceControlInputModels
{
    public class MonthlyBalanceInputModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<EntityInputModel> Entities { get; set; }

        [Required]
        public ICollection<RecurringEntityInputModel> RecurringEntities { get; set; }

        //Foreign Key
        [Required]
        public QuarterlyBalanceInputModel QuarterlyBalance { get; set; }
    }
}
