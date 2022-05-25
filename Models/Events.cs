using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gemporia_Event_Calendar.Models
{
    public class Events
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //Relationships
        public virtual Location Location { get; set; }
    }
}
