using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comhumus.Components.Models
{
    internal class TheDecision
    {
        public int Id { get; set; }
        public int PollId { get; set; }
        public required string Decision { get; set; }
        public required DateTime CreatedAt { get; set; }
        
    }
}
