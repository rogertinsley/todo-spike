using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class Item
    {
        public Guid ItemID        { get; set; }

        public Priority Priority  { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime Due       { get; set; }
    }
}
