using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet.Model
{
    using System.Data;

    using Microsoft.Data.Entity;

    public class ItemsContext : DbContext
    {
        public DbSet<ItemModel> Items { get; set; }

    }
}
