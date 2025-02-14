using System;
using System.Collections.Generic;

namespace Functions2025.Models.School;

public partial class Student
{
    public int StudentId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string School { get; set; } = null!;
}
