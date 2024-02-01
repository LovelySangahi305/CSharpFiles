using System;
using System.Collections.Generic;

namespace WebAppl2_day20.Models;

public partial class Stud
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentGender { get; set; } = null!;

    public int StudentAge { get; set; }
}
