﻿using Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Data;

public class DataSource : AuditableEntity
{
    public required string Name { get; set; }
}
