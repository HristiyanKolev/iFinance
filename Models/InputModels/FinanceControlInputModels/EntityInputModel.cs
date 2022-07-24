using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InputModels.FinanceControlInputModels
{
    public class EntityInputModel
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public decimal Value { get; set; }

        [DefaultValue("Anonymous")]
        public string Name { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        //Foreign Key
        [Required]
        public MonthlyBalanceInputModel MonthlyBalance { get; set; }
    }
}
