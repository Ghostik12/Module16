﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    public interface IUserRepository
    {
        IEnumerable < User > FindAll();
    }
}
