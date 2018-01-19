using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public static class DbInitialiser
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Items.Any()) return;

            var items = new List<Item>
            {
                new Item { Description = "Buy milk and bread", Due = DateTime.Today.AddDays(1), Priority = Priority.Medium },
                new Item { Description = "Go for a run", Due = DateTime.Today, Priority = Priority.High },
            };

            items.ForEach(i => context.Items.Add(i));

            context.SaveChanges();
        }
    }
}
