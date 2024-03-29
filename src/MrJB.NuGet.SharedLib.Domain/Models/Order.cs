using System;
using System.Collections.Generic;
using System.Text;

namespace MrJB.NuGet.SharedLib.Domain.Models;

public class Order
{
    public int? OrderId { get; set; }

    public int? CustomerId { get; set; }

    public decimal? Total { get; set; }
}
