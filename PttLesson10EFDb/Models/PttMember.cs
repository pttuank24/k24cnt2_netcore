using System;
using System.Collections.Generic;

namespace PttLesson10EFDb.Models;

public partial class PttMember
{
    public long Id { get; set; }

    public string? PttUserName { get; set; }

    public string? PttPassword { get; set; }

    public string? PttFullName { get; set; }

    public string? PttEmail { get; set; }

    public string? PttPhone { get; set; }

    public bool? PttStatus { get; set; }
}
