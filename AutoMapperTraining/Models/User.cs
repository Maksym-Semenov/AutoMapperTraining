﻿namespace AutoMapperTraining.Models;

public class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? UserRole { get; set; }
}