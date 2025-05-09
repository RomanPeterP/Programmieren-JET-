﻿namespace TableReservationSystem.Models;

public class Country
{
    public required string CountryCode { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
