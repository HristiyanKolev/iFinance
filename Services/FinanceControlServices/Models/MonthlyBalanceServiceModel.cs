using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceControlServices.Models
{
    public class MonthlyBalanceServiceModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public ICollection<EntityServiceModel> Entities { get; set; }

        [Required]
        public ICollection<RecurringEntityServiceModel> RecurringEntities { get; set; }

        //Foreign Key
        [Required]
        public QuarterlyBalanceServiceModel QuarterlyBalance { get; set; }
    }
}
