﻿namespace MrJB.NuGet.LinkedFiles.Domain.Models;

public class Customer
{
    public Guid? CustomerId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }
}
