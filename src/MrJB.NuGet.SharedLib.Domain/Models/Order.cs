﻿namespace MrJB.NuGet.SharedLib.Domain.Models;

public class Order
{
    public int? OrderId { get; set; }

    public Guid? CustomerId { get; set; }

    public decimal? Total { get; set; }
}
