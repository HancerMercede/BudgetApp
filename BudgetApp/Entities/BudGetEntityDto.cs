using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Entities
{
    public class BudGetEntityDto
    {
        public string? Description { get; set; }
        public DateTime SpendingDate { get; set; }
        public decimal Amount { get; set; }
        public string? CategoryName { get; set; }
    }
}
