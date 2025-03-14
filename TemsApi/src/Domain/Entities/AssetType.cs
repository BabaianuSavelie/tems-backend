﻿namespace Domain.Entities
{
    public class AssetType
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public List<AttributeMetadata> Attributes { get; set; }
    }
}
