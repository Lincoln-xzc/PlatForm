﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public abstract partial class BaseEntity
  {
    public int ID { get; set; }

    public DateTime CreatedAt { get; set; }
  }
}
