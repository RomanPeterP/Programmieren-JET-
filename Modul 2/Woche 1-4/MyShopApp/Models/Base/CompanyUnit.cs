﻿namespace MyShopApp.Models.Base
{
    public abstract class CompanyUnit: BusinessUnit
    {
        public required string Name { get; set; }
        public string? Uid { get; set; }
        public string? Website { get; set; }
        public string? Contact { get; set; }
    }
}
