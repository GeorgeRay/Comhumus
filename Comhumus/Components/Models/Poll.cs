using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comhumus.Components.Models
{
    public class Poll
    {
     
        public int Id { get; set; }
        public required string TheDecision { get; set; }
        public string? TheObjective { get; set; }
        public required DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
