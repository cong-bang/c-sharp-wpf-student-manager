﻿using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class UserRole
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Passphrase { get; set; }

    public int? UserRole1 { get; set; }
}
