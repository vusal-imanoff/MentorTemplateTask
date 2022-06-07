using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorTemplate.Models
{
    public class Trainers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int PositionId { get; set; }
        public string Description { get; set; }

        public Positions Position { get; set; }

    }
}
