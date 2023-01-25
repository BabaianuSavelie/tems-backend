﻿namespace Domain.Entities
{
    public class Type
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
