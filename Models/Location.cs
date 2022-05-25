using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gemporia_Event_Calendar.Models
{
    public class Location
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }

        //Relationships
        public virtual ICollection<Events> Events { get; set; }
    }
}
