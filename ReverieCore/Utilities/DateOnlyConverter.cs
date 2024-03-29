﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ReverieCore.Utilities;

public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
{
    /// <summary>
    /// Creates a new instance of this converter.
    /// </summary>
    public DateOnlyConverter() : base(dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue), dateTime => DateOnly.FromDateTime(dateTime)) { }
}