using System;

namespace Play.Catalog.Service.Entities
{
    public class Items
    {
        public Guid Id {get; set;}

        public string Name {get; set;}

        public string Description {get; set;}

        public decimal Price {get; set;}

        public DateTimeOffset CreateDate {get; set;}

    }
}