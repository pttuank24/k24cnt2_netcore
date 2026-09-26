using System;
using System.Collections.Generic;

namespace PhamTienTuan2410900082_exam.Models;

public partial class PttEmployee
{
    public long Id { get; set; }

    public string? PttName { get; set; }

    public bool? PttGender { get; set; }

    public DateOnly? PttBirthday { get; set; }

    public string? PttEmail { get; set; }

    public string? PttPhone { get; set; }

    public bool PttActive { get; set; }
}
