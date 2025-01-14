﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
